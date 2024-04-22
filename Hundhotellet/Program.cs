namespace Hundhotellet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogHotel dogHotel = new DogHotel();
            AddTestData(dogHotel);
            dogHotel.PrintInfo();
        }
        static void AddTestData(DogHotel dogHotel)
        {
            Adress testAdress1 = new Adress("Hundgatan 1", "Sala", "73333");
            Adress testAdress2 = new Adress("Kattgatan 9", "Sala", "73333");
            Owner testOwner1 = new Owner("Olle", "Eriksson", testAdress1);
            Owner testOwner2 = new Owner("Arvid", "Svensson", testAdress2);

            Dog testDog1 = new Dog("fido", "123456", testOwner1);
            Dog testDog2 = new Dog("lassie", "654321", testOwner2);
            dogHotel.SetDog(2, testDog1);
            dogHotel.SetDog(5, testDog2);


        }
    }
}