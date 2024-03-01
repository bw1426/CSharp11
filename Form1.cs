using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listyRozwijalne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //rrrrr
            InitializeComponent();
            ComboBox ob=new ComboBox();
            ob.Items.AddRange(new object[]
            {
                "a",
                "b",
                "c"
            });
            ob.Location = new Point(600, 100);
            Controls.Add(ob);
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (comboBox1.SelectedIndex)
            //{
            //    case 0:
            //        opis.Text = "poniedziałek";
            //        break;
            //    case 1:
            //        opis.Text = "wtorek";
            //        break;
            //    case 2:
            //        opis.Text = "środa";
            //        break;
            //    case 3:
            //        opis.Text = "czwartek";
            //        break;
            //    case 4:
            //        opis.Text = "piątek";
            //        break;
            //    case 5:
            //        opis.Text = "sobota";
            //        break;
            //    case 6:
            //        opis.Text = "Niedziela";
            //        break;

            //}
            switch (comboBox1.SelectedItem)
            {
                case "1":
                    opis.Text = "poniedziałek";
                    break;
                case "2":
                    opis.Text = "wtorek";
                    break;
                case "3":
                    opis.Text = "środa";
                    break;
                case "4":
                    opis.Text = "czwartek";
                    break;
                case "5":
                    opis.Text = "piątek";
                    break;
                case "6":
                    opis.Text = "sobota";
                    break;
                case "7":
                    opis.Text = "Niedziela";
                    break;

            }
        }

        private void zwierzeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (zwierzeta.SelectedIndex)
            {
                case 0:
                    obrazki.Load("pies.jpg");
                    break;
                case 1:
                    obrazki.Load("kot.jpg");
                    break;
                case 2:
                    obrazki.Load("kon.jpg");
                    break;
              
            }
        }
    }
}
