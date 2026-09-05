namespace Organization
{
    class Bank
    {
        public static void Main(string[] args)
        {
            string username = null, password = null;//assigning both with default value of string i.e null
            System.Console.WriteLine("Enter username:");
            username = System.Console.ReadLine();

            if (username != "")//dont accept pwd if username is empty
            {
                System.Console.WriteLine("Enter password:");
                password = System.Console.ReadLine();
            }

            if (username == "admin" && password == "admin")
            {
                System.Console.WriteLine("you have successfully logged in ");
              
                int mainMenuChoice = -1;//default value for main menu choice
                do
                {
                    System.Console.WriteLine("***MainMenu***");
                    System.Console.WriteLine("Press 1 for Customers Menu");
                    System.Console.WriteLine("Press 2 for Accounts Menu");
                    System.Console.WriteLine("Press 3 for FundTransfer Menu");
                    System.Console.WriteLine("Press 4 for AccountTransfer Statement Menu");
                    System.Console.WriteLine("Press 5 for Account Statement Menu");
                    System.Console.WriteLine("Press 0 for Exit");

                    //String to any numerical type->use parse
                    mainMenuChoice=int.Parse(System.Console.ReadLine());//converting string to int

                    switch (mainMenuChoice)
                    {
                        case 1:
                            System.Console.WriteLine("customer menu");
                            CustomerMenu();
                            break;
                        case 2:
                            System.Console.WriteLine("accounts menu");
                            AccountsMenu();
                            break;
                        case 3:
                            System.Console.WriteLine("fund transfer menu");
                           //Todo: FundTransferMenu();
                            break;
                        case 4:
                            System.Console.WriteLine("AccountTransfer Statement");
                            //Todo: AccountTransferStatementMenu();
                            break;
                        case 5:
                            System.Console.WriteLine("Account Statement");
                            //Todo: AccountStatementMenu();
                            break;
                        case 0:
                            System.Console.WriteLine("Exiting from main menu choice");
                            break;
                        default:
                            System.Console.WriteLine("Entered wrong main menu choice!!" );
                            break;
                    }

                } while(mainMenuChoice!=0);

            }
            else
            {
                Console.WriteLine("Wrong username/password");

            }
            Console.WriteLine("Thank you");


        }

        private static void AccountsMenu()
        {
            int accountsMenuChoice = -1;
            do
            {
                System.Console.WriteLine("Welcome to accounts section!");
                System.Console.WriteLine("Enter 1 for add account");
                System.Console.WriteLine("Enter 2 for remove account");
                System.Console.WriteLine("Enter 3 for view account");
                System.Console.WriteLine("Enter 0 for exit");

                accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());//converting string to int using convert class[Static class]

                switch (accountsMenuChoice)
                {
                    case 1:
                        System.Console.WriteLine("Account was added newly");
                        break;
                    case 2:
                        System.Console.WriteLine("Account was removed");
                        break;
                    case 3:
                        System.Console.WriteLine("Account was viewed");
                        break;
                    default:
                        Console.WriteLine("Entered wrong account menu choice!!");
                        break;
                }

            } while (accountsMenuChoice != 0);
        }

        private static void CustomerMenu()
        {
            int customerMenuChoice = -1;
            do
            {
                System.Console.WriteLine("Welcome to customers section!");
                System.Console.WriteLine("Enter 1 for add customer");
                System.Console.WriteLine("Enter 2 for remove customer");
                System.Console.WriteLine("Enter 3 for view customer");
                System.Console.WriteLine("Enter 0 for exit");

                //using Convert class- to convert string to int
                customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

                switch (customerMenuChoice)
                {
                    case 1:
                        System.Console.WriteLine("customer was added newly");
                        break;
                    case 2:
                        System.Console.WriteLine("customer was removed");
                        break;
                    case 3:
                        System.Console.WriteLine("customer was viewed");
                        break;
                    default:
                        Console.WriteLine("Entered wrong customer menu choice!!");
                        break;
                }

            } while (customerMenuChoice != 0);
        }
    }
}