namespace CityInfo.Api.Models
{
    public class CitiesDTO
    {
        public List<City> Cities { get; set; }

        public static CitiesDTO MyCities { get; set; } = new CitiesDTO();

        public CitiesDTO()
        {
            Cities = new List<City>()
            {
                new City()
                {
                    Id = 1,
                    Name = "Tehran",
                    points = new List<PointOfCity>
                    {
                        new PointOfCity()
                        {
                            Id =1,
                            Title = "milad Tower",
                            Description = "alkdajhdasjdlkasd"
                        },
                        new PointOfCity()
                        {
                            Id = 2 , 
                            Title = "Haft Tir",
                        },
                        new PointOfCity()
                        {
                            Id = 3 ,
                            Title = "Enghelab Squer",
                            Description = "adasd dadwad "
                        }
                    }
                },
                new City()
                {
                    Id= 2,
                    Name = "Berlin",
                    points = new List<PointOfCity>
                    {
                        new PointOfCity()
                        {
                            Id = 1 ,
                            Title = "Freedom Squer",
                            Description = "berlin for leben"
                        }
                    }
                },
                new City()
                {
                    Id = 3 ,
                    Name = "Milan"
                }
            };
        }
    }
}
