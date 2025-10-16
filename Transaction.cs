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
        public List<decimal> Transaktion = new List<decimal>(); //Här sparas alla poster i minnet. Aqui guardamos los registros de memoria.
        public List<decimal> Balance = new List<decimal>();
        public List<string> Description = new List<string> { "Lön, MatInköp, Gym, Hyra, Transport" };
        public List<string> Category = new List<string>();
        public decimal Amount = 0;
        public decimal Inkomster;
        public decimal Utgifter;

        public decimal AndraInkomst;
        public decimal Lön;
        public decimal MatInköp;
        public decimal Gym;
        public decimal Hyra;
        public decimal Transport;

        public void ShowInfo()
        {
           
        }
    }
}
