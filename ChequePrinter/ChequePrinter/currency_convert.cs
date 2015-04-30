using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChequePrinter
{
    class currency_convert
    {
          double yen = 0.63;
         double euro = 84.83;
         double dollar = 61.41;
         double ruble = 1.93;
         double pound = 98.75;
         double rupe;
         double retu;
        public  double convertr(string frm,string to,double mon) {

            switch(frm){
               case "Indian_Rupee":
                   rupe = mon;
                    break;
               
                case "Japanese_Yen":
                    rupe = mon*yen;
                    break;
                case "Euro":
                    rupe = mon*euro;
                    break;
                case "Rusian_Ruble":
                    rupe = mon*ruble;
                    break;
                case "UK_Pound":
                    rupe = mon*pound;
                    break;
                case "US_Dollars":
                    rupe = mon*dollar;
                    break;
                    
            }
            
            switch (to) {
                case "Indian_Rupee":
                    retu = rupe;
                    break;

                case "Japanese_Yen":
                    retu = rupe / yen;
                    break;
                case "Euro":
                    retu = rupe / euro;
                    break;
                case "Rusian_Ruble":
                    retu = rupe / ruble;
                    break;
                case "UK_Pound":
                    retu = rupe / pound;
                    break;
                case "US_Dollars":
                    retu = rupe / dollar;
                    break;
            
            }
            return retu;
        }
         
    }
}
