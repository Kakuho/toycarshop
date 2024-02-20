using VroomVroom.Models;

namespace VroomVroom.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CarContext context)
        {
            if (context.Cars.Any())
            {
                return;   // DB has been seeded
            }

            var cars = new Car[]
            {
                new Car{
                  Id=1, 
                  Name="Red Car", 
                  Description="This is a nice red car it can go vroom vroom very quickly.", 
                  Image=ImageLoader.GetBytes("./Assets/cars/1_redcar.svg"),
                  Category=Category.Basic,
                  Price=100
                },
                new Car{
                  Id=2, 
                  Name="Grey Car", 
                  Description="This is a grey car useful for going to business occasions and earning the big big money.", 
                  Image=ImageLoader.GetBytes("./Assets/cars/2_greycar.svg"),
                  Category=Category.Basic,
                  Price=150
                },
                new Car{
                  Id=3,
                  Name="Purple Car", 
                  Description="Party Car! Go out and party with girlfriends!",
                  Image=ImageLoader.GetBytes("./Assets/cars/3_purplecar.svg"),
                  Category=Category.Basic,
                  Price=200
                },

                new Car{
                  Id=4,
                  Name="Blue Car", 
                  Description="Nice blue car",
                  Image=ImageLoader.GetBytes("./Assets/cars/4_bluecar.svg"),
                  Category=Category.Basic,
                  Price=130
                },
                new Car{
                  Id=5,
                  Name="Orange Car", 
                  Description="Orange car is orange, kinda like the sun but not so bright. It has very citrusy smell inside.",
                  Image=ImageLoader.GetBytes("./Assets/cars/5_orangecar.svg"),
                  Category=Category.Basic,
                  Price=400
                },
                new Car{
                  Id=6,
                  Name="Lemon Car", 
                  Description="This is a lemon car. Why lemon? Because we already have an orange car and he was getting lonely being the only fruit themed car",
                  Image=ImageLoader.GetBytes("./Assets/cars/6_lemoncar.svg"),
                  Category=Category.Fruit,
                  Price=292
                },
                new Car{
                  Id=7,
                  Name="Lime Car", 
                  Description="Lime car decided to join the database! He is like orange and lemon where he is fruity and citrusy",
                  Image=ImageLoader.GetBytes("./Assets/cars/7_limecar.svg"),
                  Category=Category.Fruit,
                  Price=175
                },
                new Car{
                  Id=8,
                  Name="Gold Car", 
                  Description="Damnn this car is made out of gold! Shiny, Metallic and very expensive! Gold car woos everyone!",
                  Image=ImageLoader.GetBytes("./Assets/cars/8_goldcar.svg"),
                  Category=Category.Metal,
                  Price=846
                },
                new Car{
                  Id=9,
                  Name="Yellow Car", 
                  Description="Yellow car is like the sun! Much brighter than the orange car, and  give people happiness when they see the yellow car!",
                  Image=ImageLoader.GetBytes("./Assets/cars/9_yellowcar.svg"),
                  Category=Category.Basic,
                  Price=322
                },
                new Car{
                  Id=10,
                  Name="White Car", 
                  Description="A white car is a inexpensive car. This car will easily get you from point A to point B. Straightfoward yummy car",
                  Image=ImageLoader.GetBytes("./Assets/cars/10_whitecar.svg"),
                  Category=Category.Basic,
                  Price=54
                },
                new Car{
                  Id=11,
                  Name="Ocean Car", 
                  Description="Is this a car?? This ocean car lets you travel both on roads and on the ocean sea surface. Extremely cool and versatile, probably comes from the future",
                  Image=ImageLoader.GetBytes("./Assets/cars/11_oceancar.svg"),
                  Category=Category.Special,
                  Price=919
                },
                new Car{
                  Id=12,
                  Name="Strawbery Car",
                  Description="Yummy yummy - sweet like strawberry car",
                  Image=ImageLoader.GetBytes("./Assets/cars/12_strawberrycar.svg"),
                  Category=Category.Fruit,
                  Price=498
                },
                new Car{
                  Id=13,
                  Name="Iron Car",
                  Description="Goddamnn this is a car which is built from iron like the iron giant. Exremely hard, extremely well built.",
                  Image=ImageLoader.GetBytes("./Assets/cars/13_ironcar.svg"),
                  Category=Category.Metal,
                  Price=435
                },
                new Car{
                  Id=14,
                  Name="Copper Car",
                  Description="I'd be careful of this car. It's copper looks like rust. I will give you some discount btw for this car.",
                  Image=ImageLoader.GetBytes("./Assets/cars/14_coppercar.svg"),
                  Category=Category.Metal,
                  Price=245
                },
                new Car{
                  Id=15,
                  Name="Rusting Car",
                  Description="Heh, this car is actually rusting. Please be extra careful with this car. Perhaps worse than copper car.",
                  Image=ImageLoader.GetBytes("./Assets/cars/15_rustingcar.svg"),
                  Category=Category.Metal,
                  Price=220
                },
                new Car{
                  Id=16,
                  Name="Black Car",
                  Description="This car is pretty spooky! Pick this car which is black and spooky to scare people away!.",
                  Image=ImageLoader.GetBytes("./Assets/cars/16_blackcar.svg"),
                  Category=Category.Basic,
                  Price=350
                },
                new Car{
                  Id=17,
                  Name="Pink Car", 
                  Description="",
                  Image=ImageLoader.GetBytes(""),
                  Category=Category.Basic,
                  Price=0
                },
                new Car{
                  Id=18,
                  Name="Green Car", 
                  Description="",
                  Image=ImageLoader.GetBytes(""),
                  Category=Category.Basic,
                  Price=0
                },
                new Car{
                  Id=19,
                  Name="Raspberry Car", 
                  Description="",
                  Image=ImageLoader.GetBytes(""),
                  Category=Category.Basic,
                  Price=0
                },
                new Car{
                  Id=20,
                  Name="Green Car", 
                  Description="",
                  Image=ImageLoader.GetBytes(""),
                  Category=Category.Basic,
                  Price=0
                },

            };

            context.Cars.AddRange(cars);
            context.SaveChanges();
        }
    }
}
