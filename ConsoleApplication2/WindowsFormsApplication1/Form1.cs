using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] aa;
            aa = new int[2];
     

            aa[0] = 1;
            aa[1] = 2;
            listBox1.Items.Add(aa[0]);
            listBox1.Items.Add(aa[1]);
          

        }
    }
}
