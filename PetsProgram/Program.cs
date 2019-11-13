using System;
using System.Text;

namespace PetsProgram
{
    class Program
    {        
        static Cat[] cats = new Cat[0];
        static void Main(string[] args)
        {
            
        }

        private static void AddOwner()
        {            
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            string phone = Console.ReadLine();
            if(phone == " ")
            {
                Console.WriteLine("Error: Must enter a phone number");
            }
            else
            {
                Owner owner = new Owner();
                owner.FullName();
                Console.Write("Do you have a cat? (y/n): ");
                string catResponse = Console.ReadLine().ToUpper();
                if(catResponse == "Y")
                {

                    AddCat(true);

                }
                else if(catResponse == "N")
                {
                    AddCat(false);

                }

                Console.Write("Do you have a dog? (y/n): ");
                string dogResponse = Console.ReadLine();
            }

            // check if have phone number BEFORE add it to pets


            


            
        }

        // create AddDog

        public static void AddCat(bool hasCat)
        {
            bool declawed = true;
            
            if(hasCat)
            {

                Console.Write("What is your cat's name? ");
                string catName = Console.ReadLine();
                Console.Write("How old is your cat? ");
                int catAge = int.Parse(Console.ReadLine());
                Console.Write("What is the breed of your cat? ");
                string catBreed = Console.ReadLine();
                Console.Write("What color is your cat? ");
                string catColor = Console.ReadLine();
                Console.Write("Is your cat declawed? (y/n): ");
                string declawResponse = Console.ReadLine().ToUpper();
                if(declawResponse == "Y")
                {
                    declawed = true;                    
                }
                else if(declawResponse == "N")
                {
                    declawed = false;
                }
                Cat cat = new Cat(catName, catAge, catBreed, catColor, declawed);
            }
            else
            {
                Cat cat = new Cat();
            }
            
            bool declawed = false;

            
        }


        // List Owners


        // List OwnersPets

        private static string Menu()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome to the Veterinary Clinic!\n\n");
            sb.Append("1. Add new Owner\n");
            sb.Append("2. Display all owners\n");
            sb.Append("3. Display all pets by an owner\n");
            sb.Append("4. Exit\n");
            sb.Append("\n\nEnter your choice: ");

        }
    }
}
