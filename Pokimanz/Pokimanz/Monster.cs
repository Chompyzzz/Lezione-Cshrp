using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokimanz
{
    class Monster
    {
        public string name;
        public int maxHP;
        public int curHP;
        public int dmg;

        public Monster (string name, int maxHP, int dmg)
        {
            this.name = name;
            this.maxHP = maxHP;
            curHP = maxHP;
            this.dmg = dmg;
            describe();
        }

        public string describe()
        {
            string output ="Vai " + name + ", scelgo te! \r\n";
            output = output + name + " ha " + maxHP + " punti vita e " + dmg + " punti attacco";
            return output;
        }

        public void describe(TextBox t)
        {
            t.Text = describe();
        }

        public void attack(Monster target)
        {
            if (target.curHP <= 0)
            {
                Console.WriteLine(target.name + " è già esausto, non infierire.");
                return;
            }

            Console.WriteLine(name + " attacca " + target.name);
            Console.WriteLine(name + " fa " + dmg + " danni a " + target.name);
            target.curHP -= dmg;

            if (target.curHP <= 0)
            {
                target.curHP = 0;
                Console.WriteLine(target.name + " è esausto.");
            }
            else
            {
                Console.WriteLine("a " + target.name + " rimangono " + target.curHP + " hp");
            }
        }

        public void heal(Monster target)
        {

        }


    }
}
