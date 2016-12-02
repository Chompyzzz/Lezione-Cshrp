using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokimanz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Monster strongbonna = new Monster("Strongbonna", 10, 50);
            Monster charmender = new Monster("Charmender", 56, 10);
            strongbonna.attack(charmender);
            strongbonna.attack(charmender);
            strongbonna.attack(charmender);
        }
    }
}
