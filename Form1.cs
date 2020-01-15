using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerSchip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ContainerTypebox.DataSource = Enum.GetValues(typeof(Type)); 
        }
        private void CreateShip_Click(object sender, EventArgs e)
        {
            ContainerTypebox.Enabled = true;
            heightcontainertext.Enabled = true;
            lengthcontainertext.Enabled = true;
            HeightShiptext.Enabled = false;
            LengthShiptext.Enabled = false;
        }
    }
}
