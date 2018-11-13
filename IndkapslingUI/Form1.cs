using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndkapslingUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Indkapsling.PersonFuldEgenskab p1 = new Indkapsling.PersonFuldEgenskab();
            p1.Alder = 15;
            p1.Navn = "Mikkel";
            propertyGrid1.SelectedObject = p1;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Indkapsling.PersonFuldEgenskab p1 = propertyGrid1.SelectedObject as Indkapsling.PersonFuldEgenskab;

        }
    }
}
