namespace API.ViewModels
{
    public class VehicleRoute
    {
        public string from { get; set; }
        public string to { get; set; }
        public List<Listing> listings { get; set; }
    }
}
