using CarDealer.Models;

namespace CarDealer.ViewModels;

public class  CarListViewModel
{
    public List<Car> Cars { get; set; } = new();
    public string ? SearchTerm { get; set; }
    public string ? SelectedMake { get; set; }
    public int ? SelectedYear { get; set; }
    public int ? TotalCars { get; set; }
    public int ? CurrentPage { get; set; }
    public int ? TotalPages { get; set; }
}