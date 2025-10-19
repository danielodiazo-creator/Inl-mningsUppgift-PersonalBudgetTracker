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
        public List<Transaction> transactions = new List<Transaction>();  //Här skapar jag en en Lista av klassen Transaction
                                                                          //för att få tillgång till deras properties och kunna spara olika värden i dem.

        Dictionary<string, decimal> SearchCategory = new Dictionary<string, decimal>(); //Här skapar jag en dictionary som ska hjälpa oss att visa
                                                                                        //värden per category eller typ

        public void AddTransaction() // lägger till en ny post.
        {
            Transaction transaction = new Transaction();

            bool TransactionDescription = false;
            while (!TransactionDescription)
            {
                Console.WriteLine("Ange beskrivningen av transaktion");
                string beskrivningAvTransaktion = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(beskrivningAvTransaktion))                 
                {                                                                        
                    Console.WriteLine("Försök igen. Beskrivningen får inte vara töm");
                }
                else
                {
                    transaction.description = beskrivningAvTransaktion;
                    TransactionDescription = true;
                    
                }
            }
            
            bool fortsätt = false;
            while (!fortsätt)                                                   //Den här boolean ska upprepas så länge forstätt är falsk.
            {
                Console.WriteLine("Ange summan av tranktionen");
                string summaAvTransaktion = Console.ReadLine().ToLower();
                if(decimal.TryParse(summaAvTransaktion, out transaction.amount))
                {
                    fortsätt = true;
                }
                else
                {
                    Console.WriteLine("Försök igen. Skriv ett antal");
                }
                

            }
           



            Console.WriteLine("Ange typ av transaktion");
            transaction.category = Console.ReadLine().ToLower();



            transaction.date = DateTime.Now.ToString();                // På det här sättet indikerar vi det nuvarande datum

            transactions.Add(transaction);                               //Den här är en Lista
            SearchCategory.Add(transaction.category, transaction.amount);   //Den här är en Dicctionary. Det första värdet är Key. Det andra är value.

            Console.WriteLine();
        }

        
        public void ShowAll() // visar alla transaktioner.
        {
            foreach(var transaction in transactions) //För varje element i transactions ska visas följande kod:
            {         
                if(transaction.amount > 0)               // Vi lägger till grön färg om vår transaktion är positiv
                {
                   Console.ForegroundColor = ConsoleColor.Green;
                }
                else if(transaction.amount < 0)          // Vi lägger till Röd färg om vår transaktion är negativ
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

            if(SvarTransaktionBort >= 0 && SvarTransaktionBort < transactions.Count)  //Om det finns bland alternativen.
            {
               transactions.RemoveAt(SvarTransaktionBort);  //Här raderas transaktionen. 
            }
            else
            {
                Console.WriteLine("Transaktionen kunde inte tas bort");
            }
            Console.WriteLine();
        }



        public void SearchByCategory()
        {
         
            bool fortsätt = false;
            while (!fortsätt)
            {

                Console.WriteLine("Välj typ av transaktion");
                string typAvTransaktion = Console.ReadLine().ToLower();


                if (SearchCategory.ContainsKey(typAvTransaktion)) //ContainsKey kan tolkas som "har". Om Dicionary har samma string eller namn
                                                                  //raderas den från dicionary
                {

                    foreach (var element in SearchCategory)
                    {
                        if (element.Key == typAvTransaktion)     //Om den hittar samma element i dictionary ska det skrivas i consolen följande:
                        {
                            Console.WriteLine("Typ av transaktion: " + element.Key + " Transaktion: " + element.Value);
                            fortsätt = true;
                        }


                    }

                }

                else
                {
                    Console.WriteLine("Transaktionen finns inte. Försök igen.");
                    Console.WriteLine();

                }
            }
        }
        public void VisaStatistik()
        {
            
            decimal totalInkomst = 0;
            decimal totalUtgift = 0;

            foreach(var transaction in transactions)
            {
                if(transaction.amount > 0)
                {
                    
                    
                    totalInkomst = totalInkomst + transaction.amount;    //Här summerar jag alla positivia transaktioner
                    

                }
                else if(transaction.amount < 0)
                {
                    totalUtgift = totalUtgift - transaction.amount;      //Här resterar jag alla negativa transaktioner
                }

                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Din totala Inkosmt är " + totalInkomst);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Din totala utgift är " + totalUtgift);
            Console.ResetColor();
            Console.WriteLine("Dina totala antal transaktioner är " + transactions.Count);

        }
            






            



        
    }
}
