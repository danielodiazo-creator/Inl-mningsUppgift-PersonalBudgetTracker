using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift
{
    public class BudgetManager
    {
        Transaction transaction1 = new Transaction();
       
        public void AddTransaction() // – lägger till en ny post.
        {
            Console.WriteLine("Tryck [1] Mata in dina Inkomster");
            Console.WriteLine("Tryck [2] Mata in dina utgifter");
            int valdAlternativ = Convert.ToInt32(Console.ReadLine());

            switch (valdAlternativ)
            {
                case 1:

                    Console.WriteLine("Skriv in din inkomst från lönen");
                    transaction1.Lön = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Skriv in dina andra inkomster");
                    transaction1.AndraInkomst = Convert.ToDecimal(Console.ReadLine());

                    transaction1.Inkomster = transaction1.Lön + transaction1.AndraInkomst;
                    transaction1.Balance.Add(transaction1.Inkomster);

                        break;
                    
            }
        } 
        public void ShowAll() //  – visar alla transaktioner.
        {
            for(int i = 0; i < transaction1.Balance.Count; i++) 
            {

                Console.WriteLine($"Transaktion {i + 1}: {transaction1.Balance[i]} kr");

            }
            
            Console.WriteLine("Total antal transaktioner: " + transaction1.Balance.Count);
            Console.WriteLine();

        } 
        public void CalculateBalance() // – räknar ut total balans.
        {
            decimal balance = 0;
            foreach (decimal item in transaction1.Balance)
            {
                balance = balance + item;
                
            }

            Console.WriteLine(balance);

        } 
        public void DeleteTransaction() // – tar bort en post.
        {

        }
    }
}
