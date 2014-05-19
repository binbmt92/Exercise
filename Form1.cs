using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Exercise.C_;
namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student SVnamnhat = new Student();
            SVnamnhat.namestudent = "Bin";
            MessageBox.Show(SVnamnhat.namestudent);
        }
    }
}
