using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift
{
    public class MenuHelper
    {
        /*
         * Programmet ska ha minst följande menyval:
 1️⃣ ➕ Lägg till transaktion
 2️⃣ 📋 Visa alla transaktioner
 3️⃣ 💰 Visa total balans
 4️⃣ 🗑️ Ta bort transaktion
 5️⃣ 💾 Avsluta programmet

(Bonus: skapa en extra meny för att visa transaktioner per kategori.)
*/
        BudgetManager budget1 = new BudgetManager();
        
        public void Menu()
        {
            bool fortsätt = true;
            while (true)
            {
                Console.WriteLine("-----------MENU-----------------");
                Console.WriteLine("Välj alternativet som passar dig");
                Console.WriteLine();
                Console.WriteLine("1: Lägg till transaktion"); 
                Console.WriteLine("2: Visa alla transaktioner");
                Console.WriteLine("3: Visa total balans");
                Console.WriteLine("4: Ta bort transaktion");
                Console.WriteLine("5: Sök efter categoy");
                Console.WriteLine("6: Avsluta programmet");
                Console.WriteLine();

                int valdAlternativ = Convert.ToInt32(Console.ReadLine());

                switch (valdAlternativ)
                {
                    case 1: budget1.AddTransaction(); break;
                    case 2: budget1.ShowAll(); break;
                    case 3: budget1.CalculateBalance(); break;
                    case 4: budget1.DeleteTransaction(); break;
                    case 5: budget1.SearchByCategory(); break;
                    case 6: break;
                }
               


            }

        }
    }
}
