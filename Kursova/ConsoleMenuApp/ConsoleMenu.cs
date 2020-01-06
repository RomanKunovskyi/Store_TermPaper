using Bll.Abstract;
using Bll.Concrete;
using System;
using Visitor;


namespace ConsoleMenuApp
{
    public class ConsoleMenu
    {
        private readonly IUserBll User = new UserBll();
        private readonly IAdvertisingBll Advertising = new AdvertisingBll();
        private VisitorObj Visitor;

        public void Start()
        {
            FirstMenu();
        }
        private void PrintFirstMenu()
        {
            Console.WriteLine("____________HELLO_____________");
            Console.WriteLine("Sign_in______________________1");
            Console.WriteLine("Sign_up______________________2");
            Console.WriteLine("Free_visiting________________3");
            Console.WriteLine("Exid_________________________0");
        }
        private void FirstMenu()
        {

            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                PrintFirstMenu();
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Login:");
                        string login = Console.ReadLine();
                        Console.WriteLine("Password:");
                        string pasword = Console.ReadLine();
                        try
                        {
                            Visitor = new VisitorObj(login, pasword);
                            RegisteredVisitor();
                        }
                        catch
                        {
                            if (!User.LoginIsFree(login))
                            {
                                Console.Clear();
                                ChangePassword(login);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong login");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case ConsoleKey.D2:
                        //registration
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("______Person_registration_____");
                            Console.WriteLine("Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Surname: ");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Phone number: ");
                            long phone_number = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Address: ");
                            string addreess = Console.ReadLine();
                            Console.WriteLine("Born date (exampl: 1993-12-21): ");
                            DateTime born_day = Convert.ToDateTime(Console.ReadLine());

                            Console.WriteLine();
                            Console.WriteLine("______User_registration_______");
                            Console.WriteLine("Login: ");
                            string nickname = Console.ReadLine();
                            while (!User.LoginIsFree(nickname))
                            {
                                Console.WriteLine("Someone has taken this login. Pleas, take enother. ");
                                Console.WriteLine("Login: ");
                                nickname = Console.ReadLine();
                            }
                            Console.WriteLine("Password: ");
                            string password = Console.ReadLine();

                            Console.WriteLine();
                            Console.WriteLine("Special_question_regestration_");
                            Console.WriteLine("Exampl:");
                            Console.WriteLine("Question: When did you kill person first time ? ");
                            Console.WriteLine("Unswer:   2005-03-12");
                            Console.WriteLine();
                            Console.WriteLine("Question: ");
                            string question = Console.ReadLine();
                            Console.WriteLine("Answer: ");
                            string answer = Console.ReadLine();

                            User.SignUp(new Dto.UserDto(nickname, password, name, surname, phone_number, born_day, addreess, question, answer));
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong input information");
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D3:
                        UnegisteredVisitor();
                        break;
                }
            } while (key.Key != ConsoleKey.D0);
        }
        private void ChangePasswordMenu()
        {
            Console.WriteLine("______Wrong password__________");
            Console.WriteLine("Change_profil_password_______1");
            Console.WriteLine("Exid_________________________0");
        }
        private void ChangePassword(string login)
        {
            ConsoleKeyInfo key;
            bool exid = false;
            do
            {
                Console.Clear();
                ChangePasswordMenu();
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(User.GetSpesialQuestion(login));
                        Console.WriteLine();
                        Console.WriteLine("Answer:");
                        string answer = Console.ReadLine();
                        if (User.CompareAnswer(answer, login))
                        {
                            Console.WriteLine("____NEW_PASSWORD______________");
                            string new_password = Console.ReadLine();
                            User.ChangePassword(login, answer, new_password);
                            Console.WriteLine("_Pasword_has_been_changed_____");
                            exid = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("WRONG!!!");
                            exid = true;
                        }
                        break;
                }
            } while (key.Key != ConsoleKey.D0 && !exid);
        }
        private void RegisteredVisitorMenu()
        {
            Console.WriteLine("______Nice_to_see_you_again___");
            Console.WriteLine("My_purchase_history__________1");
            Console.WriteLine("Exid_________________________0");
        }
        private void RegisteredVisitor()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                RegisteredVisitorMenu();
                foreach (var info in Advertising.GetAdvertising(Visitor.GetTags()))
                {
                    Console.WriteLine(info.ToString());
                }
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        PurchoseHistor();
                        break;
                }
            } while (key.Key != ConsoleKey.D0);
        }
        private void UnegisteredVisitorMenu()
        {
            Console.WriteLine("_________Advertising__________");
            Console.WriteLine("Exid_________________________0");
        }
        private void UnegisteredVisitor()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                UnegisteredVisitorMenu();
                foreach (var info in Advertising.GetAdvertising())
                {
                    Console.WriteLine(info.ToString());
                }
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.D0);
        }
        private void PurchoseHistoryMenu()
        {
            Console.WriteLine("_____ Purchose_History________");
            Console.WriteLine("Sort_________________________1");
            Console.WriteLine("Filter_______________________2");
            Console.WriteLine("Exid_________________________0");
        }
        private void PurchoseHistor()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                PurchoseHistoryMenu();

                foreach (var info in Visitor.GetPurchaseHistoryBll().GetList())
                {
                    Console.WriteLine(info.ToString());
                }
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        PurchoseHistorySort();
                        break;
                    case ConsoleKey.D2:
                        PurchoseHistoryFilter();
                        break;

                }

            } while (key.Key != ConsoleKey.D0);
        }
        private void PurchoseHistorySortMenu()
        {
            Console.WriteLine("____________Sort______________");
            Console.WriteLine("Sort_by_cost_________________1");
            Console.WriteLine("sort_by_purchose_____________2");
            Console.WriteLine("sort_by_type_________________3");
            Console.WriteLine("sort_by_date_________________4");
            Console.WriteLine("sort_by_brand________________5");
            Console.WriteLine("Exid_________________________0");

        }
        void PurchoseHistorySort()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                PurchoseHistorySortMenu();
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Visitor.GetPurchaseHistoryBll().SortByCost();
                        return;
                    case ConsoleKey.D2:
                        Visitor.GetPurchaseHistoryBll().SortByName();
                        return;
                    case ConsoleKey.D3:
                        Visitor.GetPurchaseHistoryBll().SortByType();
                        return;
                    case ConsoleKey.D4:
                        Visitor.GetPurchaseHistoryBll().SortByDate();
                        return;
                    case ConsoleKey.D5:
                        Visitor.GetPurchaseHistoryBll().SortByBrand();
                        return;
                }
            } while (key.Key != ConsoleKey.D0);
        }
        private void PurchoseHistoryFilterMenu()
        {
            Console.WriteLine("__________________Filter_______________");
            Console.WriteLine("Find_by_name__________________________1");
            Console.WriteLine("Find_by_type__________________________2");
            Console.WriteLine("Find_by_cost__________________________3");
            Console.WriteLine("Find_by_brand_________________________4");
            Console.WriteLine("Clear_filters_and_sorts_settings______5");
            Console.WriteLine("Close_filter__________________________0");

        }
        void PurchoseHistoryFilter()
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                PurchoseHistoryFilterMenu();
                key = Console.ReadKey(true);
                try
                {
                    switch (key.Key)
                    {

                        case ConsoleKey.D1:
                            Console.Clear();
                            Console.WriteLine("Name:");
                            string name = Console.ReadLine();
                            Visitor.GetPurchaseHistoryBll().GetFilteredByNameList(name);
                            Console.Clear();
                            return;

                        case ConsoleKey.D2:
                            Console.Clear();
                            Console.WriteLine("Type:");
                            string type = Console.ReadLine();
                            Visitor.GetPurchaseHistoryBll().GetFilteredByTypeList(type);
                            Console.Clear();
                            return;

                        case ConsoleKey.D3:
                            Console.Clear();
                            Console.WriteLine("Min cost:");
                            double min = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Max cost:");
                            double max = Convert.ToDouble(Console.ReadLine());
                            Visitor.GetPurchaseHistoryBll().GetFilteredByCostList(min, max);
                            Console.Clear();
                            return;

                        case ConsoleKey.D4:
                            Console.Clear();
                            Console.WriteLine("Brand:");
                            string brand = Console.ReadLine();
                            Visitor.GetPurchaseHistoryBll().GetFilteredByBradList(brand);
                            Console.Clear();
                            return;

                        case ConsoleKey.D5:
                            Console.Clear();
                            Visitor.GetPurchaseHistoryBll().ClearSortAndFilters();
                            Console.Clear();
                            return;
                    }
                }
                catch
                {
                    Console.WriteLine("Input info error");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (key.Key != ConsoleKey.D0);
        }
    }
}
