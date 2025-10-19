using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift
{
    public class MenuHelper
    {
     
        BudgetManager budget1 = new BudgetManager();
        
        public void Menu()         // Här väljer man alternativet som bäst passar användaren med hjälp av en meny som leder till olika metoder
        {                          //Denna metoden kommer användas i Main
            bool fortsätt = true;
            while (fortsätt)
            {
                Console.WriteLine("-----------MENU-----------------");
                Console.WriteLine("Välj alternativet som passar dig");
                Console.WriteLine();
                Console.WriteLine("1: Lägg till transaktion"); 
                Console.WriteLine("2: Visa alla transaktioner");
                Console.WriteLine("3: Visa total balans");
                Console.WriteLine("4: Ta bort transaktion");
                Console.WriteLine("5: Sök efter categoy");
                Console.WriteLine("6: Visa statistik");
                Console.WriteLine("7: Avsluta programmet");
                Console.WriteLine();

                int valdAlternativ = Convert.ToInt32(Console.ReadLine());

                switch (valdAlternativ)
                {
                    case 1: budget1.AddTransaction(); break;
                    case 2: budget1.ShowAll(); break;
                    case 3: budget1.CalculateBalance(); break;
                    case 4: budget1.DeleteTransaction(); break;
                    case 5: budget1.SearchByCategory(); break;
                    case 6: budget1.VisaStatistik(); break;
                    case 7: Console.WriteLine("Programmet avslutas");
                        fortsätt = false;  break;
                }
               


            }

        }
    }
}
