namespace CityInfo.Api.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountOfPoints
        {
            get
            {
                return points.Count;
            }
        }
        public ICollection<PointOfCity> points { get; set; }= 
            new List<PointOfCity>();    
    }
}
