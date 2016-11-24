using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrikam_Foods_App
{
    public class AzureManager
    {
        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable<Bookings> bookingsTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("http://fabrikam-food-app.azurewebsites.net");

            this.bookingsTable = this.client.GetTable<Bookings>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }

        public async Task<List<Bookings>> GetBookings()
        {
            return await this.bookingsTable.ToListAsync();
        }

        public async Task AddBooking(Bookings booking)
        {
            await this.bookingsTable.InsertAsync(booking);
        }

        public async Task UpdateBooking(Bookings booking)
        {
            await this.bookingsTable.UpdateAsync(booking);
        }

        public async Task DeleteBooking(Bookings booking)
        {
            await this.bookingsTable.DeleteAsync(booking);
        }

    }
}
