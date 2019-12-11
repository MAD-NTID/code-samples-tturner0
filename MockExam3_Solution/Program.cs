using System;
using System.Text;
using System.Collections.Generic;

namespace MockExam3_Solution
{
    class Program
    {
        const string MAIN_MENU = "menu", SUB_MENU = "subMenu", STORE_TYPE = "storeType", 
                    CLOTHING = "Clothing", JEWELRY = "Jewelry", RESTAURANT = "Restaurant";
        
        const char YES = 'Y', NO = 'N';

        static List<Store> stores = new List<Store>();
        static StringBuilder sb;
        static string[] menu = { "Enter a Store", "Get Reports", "Exit" };
        static string[] subMenu = { "Report of all stores", 
            "Report of all stores of a type", 
            "Report of all restaurants with sit-down service", 
            "Report of all stores with more than 5 employees",
            "Report of all jewerly store that can repair jewelry or install batteries" };

        static string[] storeTypes = { CLOTHING, JEWELRY, RESTAURANT };

        static char yesOrNo;
        static string currentPrompt;

        static int totalEmployees;
        static double totalRevenues;
        static void Main(string[] args)
        {
            LoadData();
            while(true)
            {
                Console.Write($"{Menu()}\nSelect your preferred choice: ");

                switch(Console.ReadLine())
                {
                    case "1":
                        EnterStore();
                        Console.WriteLine("\nAdded the entry!\n");
                        break;
                    case "2":
                        string reports;
                        // Check if there is any report before displaying it to the console window
                        Console.WriteLine((reports = GetReports()) != "" ? reports : "\nNo Records\n");
                        break;
                    case "3":
                        Console.WriteLine("Exiting from the program...");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine("Error: Invalid Input, Please try again");
                        break;
                }
            }
        }

        /// <summary>
        /// Generate a menu prompt for any type based on string arrays
        /// </summary>
        /// <param name="menuType">A menu type</param>
        /// <returns>A menu prompt</returns>
        static string Menu(string menuType = MAIN_MENU)
        {
            sb = new StringBuilder();
            string[] currentMenu = menuType == STORE_TYPE ? storeTypes : (menuType == SUB_MENU) ? subMenu : menu;
            
            int startMenuNumbering = 1;

            foreach(string menuPrompt in currentMenu)
            {
                sb.Append($"{startMenuNumbering++}. {menuPrompt}\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Enter information about a store
        /// </summary>
        static void EnterStore()
        {
            Store store = null;
            string storeName, storeType, suiteNumber;
            int employeesNum;
            double monthlyRenevue;

            Console.Write(currentPrompt = $"\n{Menu(STORE_TYPE)}\nSelect the type of store: ");
            storeType = GetStoreType(currentPrompt); // Get the type of the store based on selection

            Console.Write(currentPrompt = "\nEnter the name of the store: "); // stored string in currentPrompt so it can be reuse for any repeatition
            
            while((storeName = Console.ReadLine()) == string.Empty)
            {
                Console.Write($"Error: the input cannot be empty\n{currentPrompt}");
            }

            Console.Write(currentPrompt = "Enter the suite number: ");
            while(!AddSuiteNumber(suiteNumber = Console.ReadLine()))
                Console.Write($"Error: Invalid Input, Please try again\n{currentPrompt}");

            // validating the numeric values

            Console.Write(currentPrompt = "Enter the number of employees: ");
            while(!int.TryParse(Console.ReadLine(), out employeesNum) || employeesNum < 0)
                Console.Write($"Error: Cannot be letters or negative numbers, Please try again\n{currentPrompt}");

            Console.Write(currentPrompt = "Enter the monthly revenue: ");
            while(!double.TryParse(Console.ReadLine(), out monthlyRenevue) || monthlyRenevue < 0)
                Console.Write($"Error: Cannot be letters or negative numbers, Please try again\n{currentPrompt}");

            // asking specific questions based on the type of the store
            switch(storeType)
            {
                case CLOTHING:
                    Clothing(out string style);
                    store = new Clothing(monthlyRenevue, employeesNum, storeName, suiteNumber, style);
                    break;
                case JEWELRY:
                    Jewelry(out bool repairs, out bool replaceBatteries);
                    store = new Jewelry(monthlyRenevue, employeesNum, storeName, suiteNumber, repairs, replaceBatteries);
                    break;
                case RESTAURANT:
                    Restaurant(out string restaurantType, out bool fullService);
                    store=  new Restaurant(monthlyRenevue, employeesNum, storeName, suiteNumber, restaurantType, fullService);
                    break;
            }

            stores.Add(store);                 
        }

        /// <summary>
        /// Returns any type of reports based on selection
        /// </summary>
        /// <returns>A report based on selection</returns>
        static string GetReports()
        {
            if(stores.Count == 0)
                return string.Empty;

            Console.Write($"{Menu(SUB_MENU)}\nSelect the preferred record: ");

            switch(Console.ReadLine())
            {
                case "1":
                    return GetAllStores();
                case "2":
                    Console.Write(currentPrompt = $"{Menu(STORE_TYPE)}\nSelect the type of store: ");
                    return GetAllStoresType(GetStoreType(currentPrompt));
                case "3":
                    return GetAllRestaurantsWithFullService();
                case "4": 
                    return GetAllStoresWithFiveOrMoreEmployees();
                case "5":  
                    return GetAllJewelryStoresWithServices();
                default: 
                    return "";
            }
        }

        /// <summary>
        /// Gets a report of all stores
        /// </summary>
        /// <returns>A report of all stores</returns>
        static string GetAllStores()
        {
            sb = new StringBuilder();
            totalEmployees = 0;
            totalRevenues = 0;

            foreach(Store store in stores)
            {
                totalEmployees += store.NumberOfEmployees;
                totalRevenues += store.MonthlyRevenue;
                sb.Append($"\n{store}\n");
            }

            if(!(totalEmployees == 0 ||  totalRevenues == 0))
                sb.Append($"\nTotal Of All Employees: {totalEmployees}\nTotal of All Monthly Revenues: {totalRevenues:C}\n");
                           

            return sb.ToString();
        }

        /// <summary>
        /// Gets all stores that have at least five or more employees
        /// </summary>
        /// <returns>A report of all stores with five or more employees</returns>
        static string GetAllStoresWithFiveOrMoreEmployees()
        {
            sb = new StringBuilder();
            foreach(Store store in stores)
                if(store.NumberOfEmployees >= 5) // not encouraging magic number FYI
                    sb.Append($"\n{store}\n");

            return sb.ToString();
        }

        /// <summary>
        /// Gets all restaurants that have full services
        /// </summary>
        /// <returns>A report of all restaurants with full services</returns>
         static string GetAllRestaurantsWithFullService()
        {
            sb = new StringBuilder();

            /* There are two ways to cast a store class to a specific class (Restaurant)
              in order to access their information that doesn't exist in the parent class */

            // Validating each store and check if the type of store is a restaurant type BEFORE casting the store class as a restaurant class.
            foreach(Store store in stores)
                if(store is Restaurant && (store as Restaurant).FullService) //if(store is Restaurant && ((Restaurant)store).FullService)
                    sb.Append($"\n{store}\n");

            return sb.ToString();
        }

        /// <summary>
        /// Gets all jewerly stores with services
        /// </summary>
        /// <returns>A report of all jewerly stores with services</returns>
         static string GetAllJewelryStoresWithServices()
        {
            sb = new StringBuilder();

            foreach(Store store in stores)
                if(store is Jewelry && (((Jewelry)store).DoesRepairs || ((Jewelry)store).DoesRepairs))
                    sb.Append($"\n{store}\n");

            return sb.ToString();
        }

        /// <summary>
        /// Get all stores based on a selected type of store
        /// </summary>
        /// <param name="storeType">A type of store</param>
        /// <returns>A report of all stores based on selected type</returns>
        static string GetAllStoresType(string storeType)
        {
            sb = new StringBuilder();
            totalEmployees = 0;
            totalRevenues = 0;
           
            // switch(storeType)
            // {
            //     case CLOTHING:
            //         foreach(Store store in stores)
            //         {
            //             if(store is Clothing)
            //             {
            //                 totalEmployees += store.NumberOfEmployees;
            //                 totalRevenues += store.MonthlyRevenue;    
            //                 sb.Append($"\n{store}\n");
            //             }       
            //         }
                            
            //         break;
            //     case JEWELRY:
            //         foreach(Store store in stores)
            //         {
            //             if(store is Jewelry)
            //             {
            //                 totalEmployees += store.NumberOfEmployees;
            //                 totalRevenues += store.MonthlyRevenue;    
            //                 sb.Append($"\n{store}\n");
            //             }
            //         }
            //         break;
            //     case RESTAURANT:
            //         foreach(Store store in stores)
            //         {
            //             if(store is Restaurant)
            //             {
            //                 totalEmployees += store.NumberOfEmployees;
            //                 totalRevenues += store.MonthlyRevenue;    
            //                 sb.Append($"\n{store}\n");
            //             }
            //         }
            //         break;
            // }

            // This approach is much simpler than the one above
            foreach(Store store in stores)
            {
                // validating for the specific type of store BEFORE adding the information for any purpose
                if(store.GetType().ToString() == storeType)
                {
                    totalEmployees += store.NumberOfEmployees;
                    totalRevenues += store.MonthlyRevenue;    
                    sb.Append($"\n{store}\n");
                }
            }

            // Doesnt includes information about employees or revenues if the reports do not exist.
            if(!(totalEmployees == 0 ||  totalRevenues == 0))
                sb.Append($"\nTotal Of All Employees: {totalEmployees}\nTotal of All Monthly Revenues: {totalRevenues:C}\n");

            return sb.ToString();
        }

        /// <summary>
        /// Checks if the given suite number is available to use
        /// </summary>
        /// <param name="suiteNum">A suite number given by the user</param>
        /// <returns>A permission to add/veto the given suite number</returns>
        static bool AddSuiteNumber(string suiteNum)
        {
            foreach(Store store in stores)
                if(store.SuiteNumber == suiteNum)
                    return false;

            return true;
        }

        /// <summary>
        /// Gets the type of the stored based on the user's choice
        /// </summary>
        /// <param name="currentPrompt">Current Prompt that can be reused if validation fails</param>
        /// <returns>A store type</returns>
        static string GetStoreType(string currentPrompt)
        {
            int selected;
           
           // Validating for numberic value and ensure the value is within the range
            while(!(!int.TryParse(Console.ReadLine(), out selected) || (selected >= 1 && selected <= storeTypes.Length)))
            {
                // Console.WriteLine($"Selected {selected} Range: {(selected >= 1 && selected <= storeTypes.Length)}");
                Console.Write($"Error: Invalid input or out of range, please try again\n{currentPrompt}");
            }

            return storeTypes[selected - 1];
        }

        /// <summary>
        /// Prompt the user for the preferred clothing style
        /// </summary>
        /// <param name="style">Preferred clothing style</param>
        static void Clothing(out string style)
        {
            Console.Write("Enter the preferred clothing style: ");
            style = Console.ReadLine();
        }

        /// <summary>
        /// Prompt the user for the services
        /// </summary>
        /// <param name="doesRepairs">Repairs Service Result</param>
        /// <param name="replaceBatteries">Battery Replacement Result</param>
        static void Jewelry(out bool doesRepairs, out bool replaceBatteries)
        {
            currentPrompt = "Does this jewelry store have";
            doesRepairs = YesOrNo($"{currentPrompt} the repairs service");

            replaceBatteries = YesOrNo($"{currentPrompt} the batteries replacement service for watches");
        }

        /// <summary>
        /// Prompt the user for the type of the restaurant
        /// </summary>
        /// <param name="restaurantType">Type of restaurant</param>
        /// <param name="fullService">Full Service Result</param>
        static void Restaurant(out string restaurantType, out bool fullService)
        {
            Console.Write("Enter the type of restaurant: ");
            restaurantType = Console.ReadLine();

            fullService = YesOrNo("Does the restaurant have a full service");
        }

        /// <summary>
        /// Asks and gets the final result of the user's decision
        /// </summary>
        /// <param name="prompt">Prompt that can be reused</param>
        /// <returns>Yes or No</returns>
        static bool YesOrNo(string prompt)
        {
            Console.Write(currentPrompt = $"{prompt}? (Y/N): ");
            
            while(!((yesOrNo = Console.ReadLine().ToUpper()[0]) == YES || yesOrNo == NO))
            {
                Console.Write($"Error: Invalid input, please try again\n{prompt}");
            }

            return yesOrNo == YES;
        }

        /// <summary>
        /// Preloaded data for the system to use.
        /// </summary>
        static void LoadData () {
            stores.Add(new Restaurant(6500.37, 3, "Ben & Jerry's", "57", "Ice Cream", false));
            stores.Add(new Restaurant(20551.98, 23, "Red Lobster", "58b", "Sea Food", true));
            stores.Add(new Restaurant(7083.70, 8, "Joes Crab Shack", "59", "Sea Food", true));
            stores.Add(new Restaurant(37090.06, 32, "The Outback", "62a", "Steak House", true));
            stores.Add(new Restaurant(357.82, 1, "Trager Barn", "78", "Deep Fried", false));

            stores.Add(new Clothing(7592.99, 5, "Marshal", "67a", "Casual"));
            stores.Add(new Clothing(25693.29, 7, "Hat's N Boots", "45", "Western"));
            stores.Add(new Clothing(579, 2, "Dylan's Fashion", "48b", "College Chic"));
            stores.Add(new Clothing(574893.78, 87, "JCPenney's", "43", "Soccer Mom"));
            stores.Add(new Clothing(48612.09, 15, "Musk Elon", "88", "Futuristic"));

            stores.Add(new Jewelry(84561, 24, "Kay's", "101b", true, true));
            stores.Add(new Jewelry(6700.70, 4, "A Trap", "69", false, true));
            stores.Add(new Jewelry(769859.63, 57, "Zale's", "58a", true, false));
            stores.Add(new Jewelry(5793.90, 8, "Tiffany's", "36", false, false));
            stores.Add(new Jewelry(57302.27, 26, "Everglades", "12a", true, false));
        }

    }
}
