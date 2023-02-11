using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1.Model.Soldiers;
using _1.Model.Names;
using _1.view;


Swordsman Harry = new Swordsman();
Swordsman John = new Swordsman();
Soldier Regi = new Knight();


Harry.PrintInfo();
John.PrintInfo();
Harry.Attack(John);
John.PrintInfo();

Regi.PrintInfo();
Regi.Attack(John);
John.PrintInfo();

List<Soldier> army1 = Commands.CreateArmy();
Commands.ArmyInfo(army1);
