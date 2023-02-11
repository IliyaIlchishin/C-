using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Model.Names;

namespace _1.Model.Soldiers
{


    // Абстрактный класс солдат с основным функционалом 
    public abstract class Soldier
    {
        private int MaximalHealth = 0;
        private int HP;
        private int armor = 0;
        private int PhysicalDamage = 0;
        private String Name = ""; 

        //Временные параметры
        Boolean stunned = false; 

        public Soldier()
        {
            this.Name = RandomNames.RandomName();
            this.HP = MaximalHealth;

        }


        public virtual int GetHP()
        {
            return this.HP;
        }

        protected virtual int SetHP(int a)
        {
            return this.HP;
        }
        public virtual int GetArmorValue()
        {
            return this.armor;
        }

        public virtual int SetArmorValue(int a)
        {
            return this.armor;
        }
        public virtual int GetDamage(int value)
        {
            this.HP = HP - value;
            return this.HP;
        }
        public virtual String GetName()
        {
            return this.Name;
        }

        public virtual Boolean GetStunStatus()
        {
            return this.stunned;
        }
        public virtual void SetStunEffect()
        {
            if (this.stunned == false) { this.stunned = true; }
            else if (this.stunned == true) { this.stunned = false; }

        }

        public virtual void Attack(Soldier a)
        {

            int damage = this.PhysicalDamage-a.GetArmorValue();
            a.GetDamage(damage);
    

        }
        public virtual void PrintInfo(){
            System.Console.WriteLine("==================");
            System.Console.WriteLine($"||    HP - {this.HP}" );
            
            System.Console.WriteLine($"||    Armor - {this.armor}" );
            
            System.Console.WriteLine($"||    Attack - {this.PhysicalDamage} " );
            
            System.Console.WriteLine("==================");
            
        
        }






//         public int StudentId
// {
//     get { return id; }

//     set {
//         if (value > 0)
//             id = value;
//     }
// }

    
        
    }
}