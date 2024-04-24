namespace Hundhotellet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogHotel dogHotel = new DogHotel();
            AddTestData(dogHotel);
            Console.WriteLine("\n\rDog and Owner Info");
            dogHotel.PrintInfo();
            Console.WriteLine("\n\rFeedingSchedule");
            dogHotel.PrintFeedingSchedule();
            Console.WriteLine("\n\rVisitTime");
            dogHotel.PrintPickups();
        }
        static void AddTestData(DogHotel dogHotel)
        {
            Adress testAdress1 = new Adress("Hundgatan 1", "Sala", "73333");
            Adress testAdress2 = new Adress("Kattgatan 9", "Sala", "73333");
            Owner testOwner1 = new Owner("Olle", "Eriksson", testAdress1);
            Owner testOwner2 = new Owner("Arvid", "Svensson", testAdress2);
            Meal testMeal1 = new Meal(7, "Pedigree Adult Maxi Beef & Rice", "två skopor");
            Meal testMeal2 = new Meal(7, "Doggy paté med kalkon", "tre skopor");
            Visit testTime1 = new Visit(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0));
            Visit testTime2 = new Visit(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 6,0,0), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0));

            Dog testDog1 = new Dog("fido", "123456", testOwner1, testTime1);
            Dog testDog2 = new Dog("lassie", "654321", testOwner2, testTime2);
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);
            testDog1.AddMeal(testMeal1);
            testDog2.AddMeal(testMeal2);

        }
    }
}