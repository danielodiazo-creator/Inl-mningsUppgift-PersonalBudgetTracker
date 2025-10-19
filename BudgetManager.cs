using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift
{
    public class BudgetManager
    {
        public List<Transaction> transactions = new List<Transaction>();
        Dictionary<string, decimal> SearchCategory = new Dictionary<string, decimal>();

        public void AddTransaction() // lägger till en ny post.
        {
            Transaction transaction = new Transaction();

            Console.WriteLine("Ange beskrivningen av transaktion");
            transaction.description = Console.ReadLine();

            Console.WriteLine("Ange summan av tranktionen");
            transaction.amount = Convert.ToDecimal(Console.ReadLine());



            Console.WriteLine("Ange typ av transaktion");
            transaction.category = Console.ReadLine();



            transaction.date = DateTime.Now.ToString();

            transactions.Add(transaction);
            SearchCategory.Add(transaction.category, transaction.amount);

            Console.WriteLine();
        }

        
        public void ShowAll() // visar alla transaktioner.
        {
            foreach(var transaction in transactions)
            {         
                if(transaction.amount > 0)
                {
                   Console.ForegroundColor = ConsoleColor.Green;
                }
                else if(transaction.amount < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }


                    transaction.ShowInfo();
             
            }

            Console.ResetColor();

            Console.WriteLine("Antal transaktioner: " + transactions.Count);
            Console.WriteLine();

        } 
        public void CalculateBalance() // räknar ut total balans.
        {
            decimal balance = 0;

            foreach(var transaction in transactions)
            {
                balance = balance + transaction.amount;
            }

            if (balance > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (balance < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
            }

            Console.WriteLine("Balance: " + balance);
            Console.ResetColor();
            Console.WriteLine();
        } 
        public void DeleteTransaction() // tar bort en post.
        {
            Console.WriteLine("Välj vilken transaktion som ska tas bort");
            int SvarTransaktionBort = Convert.ToInt32(Console.ReadLine());

            if(SvarTransaktionBort > 0 && SvarTransaktionBort < transactions.Count)
            {
               transactions.RemoveAt(SvarTransaktionBort);
            }
            else
            {
                Console.WriteLine("Transaktionen kunde inte tas bort");
            }
            Console.WriteLine();
        }



        public void SearchByCategory()
        {
            Console.WriteLine("Välj typ av transaktion");
            string typAvTransaktion = Console.ReadLine();

            if (SearchCategory.ContainsKey(typAvTransaktion))
            {

                foreach (var element in SearchCategory)
                {
                    if (element.Key == typAvTransaktion)
                    {
                        Console.WriteLine("Transaktion Category: " + element.Value + " Transaktion: " + element.Key);
                    }


                }

            }

        }
        public void VisaStatistik()
        {
            int antalTransaktioner = 0;





        }
            






            



        
    }
}
