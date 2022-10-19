using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zufall
{
    class Spiel
    {

        public static int zufall()

        { 
       

            Random zufallszahl = new Random();
           int Zah = zufallszahl.Next(0,3);
            return Zah;
        
        }

        public static string gewinn (int z1p,int z2p,int z3p,int a1,int a2,int a3)
        {
           if(z1p==a1&&z2p==a2&&z3p==a3)
           {
               return "jackpot";
           }
           else if(z1p==a1&&z2p==a2||z1p==a1&&z3p==a3||z2p==a2&&z3p==a3)
           {
           
               return "hauptgewinn";


           }
            else 
           {

               return "leider kein gewinn";
           
           
           
           }

        
        
        
        
        }















    }
}
