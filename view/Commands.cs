using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Model.Soldiers;
using _1.Model.Names;


namespace _1.view
{
    public class Commands
    {

        // Создаем список с рандомными солдатами 
        public static List <Soldier> CreateArmy (){
            List <Soldier> army = new List<Soldier>();
            
            System.Console.WriteLine("Выберите тип и кол-во солдат для найма");
            System.Console.WriteLine("1 - Мечник, 2 - Рыцарь");
            int type = Convert.ToInt32 (Console.ReadLine());
            System.Console.WriteLine("Введите кол-во");
            int quantity = Convert.ToInt32 (Console.ReadLine());

            if (type == 1){
                for (int i = 0; i<quantity+1; i++){
                army.Add(new Swordsman());
                }
            }
            if (type == 2){
                for (int i = 0; i<quantity+1; i++){
                army.Add(new Knight());
                }
            }

            return army;
        }

        //печатаем общую инфу и вызывает метод PrintInfo из класса Soldier для выведения информации об экземлярах класса Soldier
        public static void ArmyInfo(List <Soldier> army){
            int size = army.Count-1;
            System.Console.WriteLine($"Размер армии - {size}\n");
            for (int i=0; i <size;i++)
            army[i].PrintInfo();
        }


    }



}