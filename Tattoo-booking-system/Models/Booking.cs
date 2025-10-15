using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
    
    public int Id { get; set; }
    
    [DataType(DataType.Date)]
    [DisplayName("SelectedDate")]
    public DateOnly SelectedDate { get; set; }
    
    [DataType(DataType.Time)]
    [DisplayName("SelectedStartTime")]
    public TimeOnly SelectedStartTime { get; set; }
    
    [DataType(DataType.Time)]
    [DisplayName("SelectedEndTime")]
    public TimeOnly SelectedEndTime { get; set; }
    
    
    
}
