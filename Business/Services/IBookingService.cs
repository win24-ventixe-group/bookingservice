using System.Threading.Tasks;
using Business.Models;

namespace Business.Services;

public interface IBookingService
{
    Task<BookingResult> CreateBookingAsync(CreateBookingRequest request);
}