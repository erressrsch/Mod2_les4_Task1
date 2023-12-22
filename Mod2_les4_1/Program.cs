using System;


namespace Mod2_les4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new()
            {
                firstname = "Marian",
                lastname = "Wielkopolski",
                age = 38,
                gender = 'm',
                pesel = "85101009000",
                id = 3108765
            };

            Console.WriteLine(data.firstname);
            Console.WriteLine(data.lastname);
            Console.WriteLine(data.age);
            Console.WriteLine(data.gender);
            Console.WriteLine(data.pesel);
            Console.WriteLine(data.id);




        }

    }
}