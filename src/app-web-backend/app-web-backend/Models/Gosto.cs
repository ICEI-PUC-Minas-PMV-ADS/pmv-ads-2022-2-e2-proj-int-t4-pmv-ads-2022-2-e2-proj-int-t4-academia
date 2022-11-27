//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms

//namespace app_web_backend.Models
//{
//    [Table("Gosto")]

//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string msg = "";

//            if (checkBox1.Checked == true)
//            {
//                msg = "Bike";
//            }

//            if (checkBox2.Checked == true)
//            {
//                msg = msg + "Musculação";
//            }

//            if (checkBox3.Checked == true)
//            {
//                msg = msg + "Crossfit";
//            }

//            if (checkBox4.Checked == true)
//            {
//                msg = msg + "Triatlon";
//            }

//            if (checkBox5.Checked == true)
//            {
//                msg = msg + "Spinning";
//            }

//            if (checkBox6.Checked == true)
//            {
//                msg = msg + "Bike Outdoor";
//            }

//            if (checkBox7.Checked == true)
//            {
//                msg = msg + "Corrida";
//            }

//            if (checkBox8.Checked == true)
//            {
//                msg = msg + "Trino Funcional";
//            }

//            if (checkBox9.Checked == true)
//            {
//                msg = msg + "Pilates";
//            }

//            if (checkBox10.Checked == true)
//            {
//                msg = "Sertanejo Universitário";
//            }

//            if (checkBox11.Checked == true)
//            {
//                msg = msg + "Forró";
//            }

//            if (checkBox12.Checked == true)
//            {
//                msg = msg + "Zumba";
//            }

//            if (checkBox13.Checked == true)
//            {
//                msg = msg + "Hip-Hop";
//            }

//            if (checkBox14.Checked == true)
//            {
//                msg = msg + "Dança de Salão";
//            }

//            if (checkBox15.Checked == true)
//            {
//                msg = msg + "Fit Dance";
//            }

//            if (checkBox16.Checked == true)
//            {
//                msg = msg + "Capoeira";
//            }

//            if (checkBox17.Checked == true)
//            {
//                msg = msg + "Boxe";
//            }

//            if (checkBox18.Checked == true)
//            {
//                msg = msg + "Jiu Jitsu";
//            }

//            if (checkBox19.Checked == true)
//            {
//                msg = "Capoeira";
//            }

//            if (checkBox20.Checked == true)
//            {
//                msg = msg + "Boxe";
//            }

//            if (checkBox21.Checked == true)
//            {
//                msg = msg + "Jiu Jitsu";
//            }

//            if (checkBox22.Checked == true)
//            {
//                msg = msg + "Homens";
//            }

//            if (checkBox23.Checked == true)
//            {
//                msg = msg + "Mulheres";
//            }

//            if (checkBox24.Checked == true)
//            {
//                msg = msg + "LGBTQIA+";
//            }

//            if (checkBox25.Checked == true)
//            {
//                msg = msg + "Não tenho preferência";
//            }

//            if (msg.Length > 0)
//            {
//                MessageBox.Show(msg + " selected ");
//            }
//            else
//            {
//                MessageBox.Show("Nennhuma preferência selecionada");
//            }

//            checkBox1.ThreeState = true;
//        }
//    }
//}