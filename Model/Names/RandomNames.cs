using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace _1.Model.Names
{
    public class RandomNames
    {
        static String [] Names = new String[8]{"Иван","Арнольд", "Владимир", "Генри", "Петр", "Ричард", "Борис", "Иннокентий" };


        public static String RandomName (){

            int randname = new Random ().Next (0,Names.Length-1); 

            String name = Names[randname];
            return name; 
        }
    }
}