using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift
{

    /*Klass: Transaction
 🧾 Innehåller egenskaper för:
Description (t.ex. “Lön”, “Matinköp”)
Amount (decimal, positivt = inkomst, negativt = utgift)
Category (t.ex. “Mat”, “Transport”, “Hyra”, “Inkomst”)
Date (skrivs som text, t.ex. “2025-10-10”)
💬 Metod:
ShowInfo() – skriver ut all information om transaktionen.



    */


    public class Transaction  //Representerar en inkomst eller utgift. Representa un ingreso o gasto.  
    {
        public string description;
        public decimal amount;
        public string category;
        public string date;

        public void ShowInfo()
        {
            Console.WriteLine($"-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{description} | {amount} kr | {category} | {date}");
            Console.WriteLine($"-----------------------------------------------------------------------------------------------------------");
        }
    }
}
