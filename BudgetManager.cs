using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift
{
    public class BudgetManager
    {
        public List<Transaction> transactions = new List<Transaction>();
        
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

            Console.WriteLine();


        } 
        public void ShowAll() // visar alla transaktioner.
        {
            foreach(var transaction in transactions)
            {         
                transaction.ShowInfo();
             
            }

            Console.WriteLine("Antal transaktioner: " + transactions.Count);

        } 
        public void CalculateBalance() // räknar ut total balans.
        {
            decimal balance = 0;

            foreach(var transaction in transactions)
            {
                balance = balance + transaction.amount;
            }

            Console.WriteLine("Balance: " + balance);
        } 
        public void DeleteTransaction() // tar bort en post.
        {
            Console.WriteLine("Välj vilken transaktion som ska tas bort");


        }
    }
}
