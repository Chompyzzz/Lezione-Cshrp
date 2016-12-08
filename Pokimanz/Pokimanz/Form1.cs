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
            Monster exeggutor  = new Monster("Exeggutor", 167, 47);
            Monster palmer = new Monster("Palmer", 113, 34, 25);
            exeggutor.attack(palmer);
            palmer.attack(exeggutor);
            exeggutor.attack(palmer);
            palmer.heal();
            palmer.heal();
            exeggutor.attack(palmer);
            exeggutor.attack(palmer);
        }
    }
}
