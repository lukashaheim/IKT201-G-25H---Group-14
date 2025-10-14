namespace Tattoo_booking_system.Models;

public class Booking
{
    public Booking() {}

    public Booking(DateOnly selectedDate, TimeOnly selectedStartTime, TimeOnly selectedEndTime)
    {
        SelectedDate =  selectedDate;
        SelectedStartTime = selectedStartTime;
        SelectedEndTime =  selectedEndTime;
    }
}