class MenuApp 
{

    public void ShowMenu()
    {
        bool exit = false;
        int option;

        while (!exit)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("           POCKET BANK             ");
            Console.WriteLine("===================================");

            Console.WriteLine("1. Información de servicios");
            Console.WriteLine("2. Iniciar sesión");
            Console.WriteLine("3. Salir");

            if (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
            {
                Console.WriteLine("Opción no válida. Inserte una opción entre 1 y 3");
                continue;
            }

            switch (option)
            {
                case 1:
                    ShowInformation();
                    break;
                case 2:
                    LogIn();
                    break;
                case 3:
                    exit = true;   
                    Console.WriteLine("Saliendo de la App...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }



        
        private void ShowInformation()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("      Información de servicios      ");
            Console.WriteLine("====================================");
        }

        private void LogIn()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("        LogIn - Área Privada        ");
            Console.WriteLine("====================================");
        }
            

            
}