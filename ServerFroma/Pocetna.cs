using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerForma
{
    public partial class Pocetna : Form
    {
        Server s;
        public Pocetna()
        {
            InitializeComponent();
            s = new Server();
            s.PokreniServer();
            lblStatus.Text = "Server je pokrenut!";
        }

       
    }
}
