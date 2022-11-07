using BookingAPI.Models.BookingModels;
using BookingAPI.Models.CustomerModels;
using System.Text.RegularExpressions;

namespace BookingAPI.Utilities
{
    public static class ExtensionMethods
    {
        public static bool isFiscalCodeValid(this string fiscalCode)
        {
            return Regex.IsMatch(fiscalCode, "^[A-Z]{6}[0-9]{2}[A-Z][0-9]{2}[A-Z][0-9]{3}[A-Z]$");
        }

        public static bool isBookingAvailable(this IEnumerable<Booking> bookings,PostBooking objectValue)
        {
            return bookings.Where(booking => booking.ApartmentId == objectValue.ApartmentId)
                                                .All(booking => booking.StartDate > objectValue.EndDate || booking.EndDate < objectValue.StartDate);
        }
    }
}
