using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Model.Names;

namespace _1.Model.Soldiers
{
    public class Swordsman : Soldier
    {
        private int MaximalHealth = 100;
        private int HP;
        private int armor = 10;
        private int PhysicalDamage = 25;
        private String Name = "";
        private String Type = "Мечник";


        //Временные параметры
        Boolean stunned = false;


        public Swordsman()
        {
            this.Name = RandomNames.RandomName();
            this.HP = MaximalHealth;

        }

        public override int GetHP()
        {
            return this.HP;
        }

        public override int GetDamage(int value)
        {
            this.HP = HP - value;
            return this.HP;
        }
        public override int GetArmorValue()
        {
            return this.armor;
        }
        public override int SetArmorValue(int a)
        {
            return this.armor;
        }

        public override String GetName()
        {
            return this.Name;
        }
        public override void Attack(Soldier a)
        {
            int multiplier = 1;

            if (a.GetStunStatus() == true) { multiplier = 2; }

            int damage = (this.PhysicalDamage * 2) - a.GetArmorValue();
            System.Console.WriteLine($"{this.Name} наносит {damage} ед. урона {a.GetName()}");
            a.GetDamage(damage);

        }

        public override void PrintInfo()
        {
            System.Console.WriteLine("==================");
            System.Console.WriteLine($"||    Имя - {this.Name}");
            System.Console.WriteLine($"||    Класс - {this.Type}");
            System.Console.WriteLine($"||    Здоровье - {this.HP}");
            System.Console.WriteLine($"||    Броня - {this.armor}");
            System.Console.WriteLine($"||    Урон - {this.PhysicalDamage} ");
            System.Console.WriteLine("==================");

        }

        protected void Death()
        {

            if (this.HP == 0)
            {
                System.Console.WriteLine("Soldier is dead");
            }

        }

    }
}