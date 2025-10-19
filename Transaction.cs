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
        public string description;   //Här skapar jag 4 properties enligt Uppgiften. 
        public decimal amount;
        public string category;
        public string date;

        public void ShowInfo()    //Här ska jag visa properties Values eller värden i Konsolen
        {
            Console.WriteLine($"-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"|    {description}    |    {amount}kr    |    {category}    |    {date}    |");
            Console.WriteLine($"-----------------------------------------------------------------------------------------------------------");
        }
    }
}
