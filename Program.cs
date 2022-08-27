using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero()
            {
                MainColor = "blue",
                MaximumOccupancy = 1
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "green",
                MaximumOccupancy = 3
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "red",
                MaximumOccupancy = 5
            };
            Ram ram1500= new Ram()
            {
                MainColor = "yellow",
                MaximumOccupancy = 4
            };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            ram1500.Drive();
            ram1500.Turn("left");
            fxs.Stop();
        }
    }
}
