using Fabrikam_Foods_App;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(AzureDataService))]
namespace Fabrikam_Foods_App
{
    public class AzureDataService
    {
        public MobileServiceClient MobileService { get; set; } = null;
        IMobileServiceSyncTable<Bookings> bookingTable;

        public async Task Initialize()
        {
            MobileService = new MobileServiceClient("http://fabrikam-food-app.azurewebsites.net");

            const string path = "syncstore.db";

            //setup our local sqlite store and intialize our table
            var store = new MobileServiceSQLiteStore(path);
            store.DefineTable<Bookings>();

            await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());

            //Get our sync table that will call out to azure
            bookingTable = MobileService.GetSyncTable<Bookings>();

        }

        public async Task<IEnumerable> GetBooking()
        {
            await Initialize();
            await SyncBooking();

            return await bookingTable.OrderBy(c => c.Date).ToEnumerableAsync();
        }

        public async Task<Bookings> AddBooking(string name, string email, int number, DateTime date, TimeSpan time)
        {
            await Initialize();

            //create and insert coffee
            var booking = new Bookings
            {
                Name = name,
                Email = email,
                Number = number,
                Date = date,
                Time = time
            };

            await bookingTable.InsertAsync(booking);

            //Synchronize coffee
            //await SyncBooking();

            return booking;
        }

        public async Task SyncBooking()
        {
            // pull down all latest changes and then push current coffees up
            await bookingTable.PullAsync("allCoffees", bookingTable.CreateQuery());
            await MobileService.SyncContext.PushAsync();
        }
    }
}
