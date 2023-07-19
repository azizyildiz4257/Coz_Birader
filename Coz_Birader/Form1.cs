using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Data.SqlClient;


namespace Coz_Birader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //oyun taşlarını png yapmak için
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox1.Controls.Add(pictureBox3);
            pictureBox1.Controls.Add(pictureBox4);
            pictureBox1.Controls.Add(pictureBox5);
            pictureBox1.Controls.Add(pictureBox10);
            pictureBox1.Controls.Add(pictureBox11);
            pictureBox1.Controls.Add(pictureBox12);
            pictureBox1.Controls.Add(pictureBox13);
            pictureBox1.Controls.Add(pictureBox14);
            pictureBox1.Controls.Add(pictureBox15);
            pictureBox1.Controls.Add(pictureBox16);
            pictureBox1.Controls.Add(pictureBox17);
            pictureBox1.Controls.Add(pictureBox18);
            pictureBox1.Controls.Add(pictureBox19);
            pictureBox1.Controls.Add(pictureBox20);
            pictureBox1.Controls.Add(pictureBox21);

            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
            pictureBox19.BackColor = Color.Transparent;
            pictureBox20.BackColor = Color.Transparent;
            pictureBox21.BackColor = Color.Transparent;
        }

        Random zar = new Random();
        int[] konx = new int[] { 13, 62, 116, 169, 236, 236, 236, 236, 236, 295, 351, 351, 351, 351, 351, 402, 458, 515, 569, 569, 569, 516, 459, 402, 351, 351, 351, 351, 351, 295, 236, 236, 236, 236, 236, 170, 116, 62, 13, 13 };
        int[] kony = new int[] { 236, 236, 236, 236, 236, 176, 118, 62, 12, 12, 12, 61, 116, 168, 231, 231, 231, 231, 231, 293, 349, 349, 349, 349, 349, 405, 458, 512, 573, 573, 573, 517, 460, 404, 350, 350, 350, 350, 350, 294 };

        int[] mavikonx = new int[] { 351, 351, 351, 351, 351, 402, 458, 515, 569, 569, 569, 516, 459, 402, 351, 351, 351, 351, 351, 295, 236, 236, 236, 236, 236, 170, 116, 62, 13, 13, 13, 62, 116, 169, 236, 236, 236, 236, 236, 295 };
        int[] mavikony = new int[] { 12, 61, 116, 168, 231, 231, 231, 231, 231, 293, 349, 349, 349, 349, 349, 405, 458, 512, 573, 573, 573, 517, 460, 404, 350, 350, 350, 350, 350, 294, 236, 236, 236, 236, 236, 176, 118, 62, 12, 12 };

        int[] yeşilkonx = new int[] { 569, 516, 459, 402, 351, 351, 351, 351, 351, 295, 236, 236, 236, 236, 236, 170, 116, 62, 13, 13, 13, 62, 116, 169, 236, 236, 236, 236, 236, 295, 351, 351, 351, 351, 351, 402, 458, 515, 569, 569 };
        int[] yeşilkony = new int[] { 349, 349, 349, 349, 349, 405, 458, 512, 573, 573, 573, 517, 460, 404, 350, 350, 350, 350, 350, 294, 236, 236, 236, 236, 236, 176, 118, 62, 12, 12, 12, 61, 116, 168, 231, 231, 231, 231, 231, 293 };

        int[] sarıkonx = new int[] { 236, 236, 236, 236, 236, 170, 116, 62, 13, 13, 13, 62, 116, 169, 236, 236, 236, 236, 236, 295, 351, 351, 351, 351, 351, 402, 458, 515, 569, 569, 569, 516, 459, 402, 351, 351, 351, 351, 351, 295 };
        int[] sarıkony = new int[] { 573, 517, 460, 404, 350, 350, 350, 350, 350, 294, 236, 236, 236, 236, 236, 176, 118, 62, 12, 12, 12, 61, 116, 168, 231, 231, 231, 231, 231, 293, 349, 349, 349, 349, 349, 405, 458, 512, 573, 573 };

        int[] konredx = new int[] { 67, 123, 180, 234 };
        int[] konredy = new int[] { 292, 292, 292, 292 };

        int[] konbluex = new int[] { 292, 292, 292, 292 };
        int[] konbluey = new int[] { 65, 121, 178, 232 };

        int[] kongreenx = new int[] { 518, 464, 407, 350 };
        int[] kongreeny = new int[] { 292, 292, 292, 292 };

        int[] konyellowx = new int[] { 292, 292, 292, 292 };
        int[] konyellowy = new int[] { 518, 462, 404, 351 };

        string[] sıralama = new string[] { "0", "0", "0", "0" };

        int redtaskon = 0, redbitis = 0;
        int bluetaskon = 0, bluebitis = 0;
        int greentaskon = 0, greenbitis = 0;
        int yellowtaskon = 0, yellowbitis = 0;

        bool startred = false;
        bool startblue = false;
        bool startgreen = false;
        bool startyellow = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
            pictureBox2.Location = new Point(12, 12);
            pictureBox3.Location = new Point(69, 10);
            pictureBox4.Location = new Point(12, 65);
            pictureBox5.Location = new Point(69, 63);

            pictureBox10.Location = new Point(511, 8);
            pictureBox12.Location = new Point(511, 61);
            pictureBox11.Location = new Point(570, 8);
            pictureBox13.Location = new Point(570, 61);

            Btn_yellowSor.Visible = false;
            Btn_blueSor.Visible = false;
            Btn_greenSor.Visible = false;

            Btn_A.Enabled = false;
            Btn_B.Enabled = false;
            Btn_C.Enabled = false;
            Btn_D.Enabled = false;
            button9.Visible = false;

        }

        //Yeniden başla
        private void button9_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Listbox Temizle
        private void button10_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listekle(string y)
        {
            listBox1.Items.Add(y);
            if (listBox1.Items.Count > 6)
                listBox1.Items.RemoveAt(0);
        }

        private void kırmızıye()
        {
            if ((pictureBox3.Location == pictureBox10.Location) || (pictureBox2.Location == pictureBox10.Location) || (pictureBox5.Location == pictureBox10.Location) || (pictureBox4.Location == pictureBox10.Location))
            {
                pictureBox10.Location = new Point(511, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 0;
                listekle("Kızmızı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox11.Location) || (pictureBox2.Location == pictureBox11.Location) || (pictureBox5.Location == pictureBox11.Location) || (pictureBox4.Location == pictureBox11.Location))
            {
                pictureBox11.Location = new Point(570, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 4;
                listekle("Kızmızı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox12.Location) || (pictureBox2.Location == pictureBox12.Location) || (pictureBox5.Location == pictureBox12.Location) || (pictureBox4.Location == pictureBox12.Location))
            {
                pictureBox12.Location = new Point(511, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 2;
                listekle("Kızmızı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox13.Location) || (pictureBox2.Location == pictureBox13.Location) || (pictureBox5.Location == pictureBox13.Location) || (pictureBox4.Location == pictureBox13.Location))
            {
                pictureBox13.Location = new Point(570, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 6;
                listekle("Kızmızı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox14.Location) || (pictureBox2.Location == pictureBox14.Location) || (pictureBox5.Location == pictureBox14.Location) || (pictureBox4.Location == pictureBox14.Location))
            {
                pictureBox14.Location = new Point(513, 517);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 2;
                listekle("Kızmızı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox15.Location) || (pictureBox2.Location == pictureBox15.Location) || (pictureBox5.Location == pictureBox15.Location) || (pictureBox4.Location == pictureBox15.Location))
            {
                pictureBox15.Location = new Point(570, 515);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 0;
                listekle("Kızmızı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox16.Location) || (pictureBox2.Location == pictureBox16.Location) || (pictureBox5.Location == pictureBox16.Location) || (pictureBox4.Location == pictureBox16.Location))
            {
                pictureBox16.Location = new Point(513, 574);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 6;
                listekle("Kızmızı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox17.Location) || (pictureBox2.Location == pictureBox17.Location) || (pictureBox5.Location == pictureBox17.Location) || (pictureBox4.Location == pictureBox17.Location))
            {
                pictureBox17.Location = new Point(570, 577);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 4;
                listekle("Kızmızı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox18.Location) || (pictureBox2.Location == pictureBox18.Location) || (pictureBox5.Location == pictureBox18.Location) || (pictureBox4.Location == pictureBox18.Location))
            {
                pictureBox18.Location = new Point(12, 514);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 6;
                listekle("Kızmızı oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox19.Location) || (pictureBox2.Location == pictureBox19.Location) || (pictureBox5.Location == pictureBox19.Location) || (pictureBox4.Location == pictureBox19.Location))
            {
                pictureBox19.Location = new Point(68, 515);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 2;
                listekle("Kızmızı oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox20.Location) || (pictureBox2.Location == pictureBox20.Location) || (pictureBox5.Location == pictureBox20.Location) || (pictureBox4.Location == pictureBox20.Location))
            {
                pictureBox20.Location = new Point(13, 576);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 4;
                listekle("Kızmızı oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox3.Location == pictureBox21.Location) || (pictureBox2.Location == pictureBox21.Location) || (pictureBox5.Location == pictureBox21.Location) || (pictureBox4.Location == pictureBox21.Location))
            {
                pictureBox21.Location = new Point(68, 575);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 0;
                listekle("Kızmızı oyuncu Sarı oyuncunun taşını yedi");
            }
        }

        private void maviye()
        {
            if ((pictureBox10.Location == pictureBox4.Location) || (pictureBox11.Location == pictureBox4.Location) || (pictureBox12.Location == pictureBox4.Location) || (pictureBox13.Location == pictureBox4.Location))
            {
                pictureBox4.Location = new Point(12, 65);
                redtaskon = 0;
                startred = false;
                redbitis = 0;
                listekle("Mavi oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox5.Location) || (pictureBox11.Location == pictureBox5.Location) || (pictureBox12.Location == pictureBox5.Location) || (pictureBox13.Location == pictureBox5.Location))
            {
                pictureBox5.Location = new Point(69, 63);
                redtaskon = 0;
                startred = false;
                redbitis = 2;
                listekle("Mavi oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox2.Location) || (pictureBox11.Location == pictureBox2.Location) || (pictureBox12.Location == pictureBox2.Location) || (pictureBox13.Location == pictureBox2.Location))
            {
                pictureBox2.Location = new Point(12, 12);
                redtaskon = 0;
                startred = false;
                redbitis = 4;
                listekle("Mavi oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox3.Location) || (pictureBox11.Location == pictureBox3.Location) || (pictureBox12.Location == pictureBox3.Location) || (pictureBox13.Location == pictureBox3.Location))
            {
                pictureBox3.Location = new Point(69, 10);
                redtaskon = 0;
                startred = false;
                redbitis = 6;
                listekle("Mavi oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox14.Location) || (pictureBox11.Location == pictureBox14.Location) || (pictureBox12.Location == pictureBox14.Location) || (pictureBox13.Location == pictureBox14.Location))
            {
                pictureBox14.Location = new Point(513, 517);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 2;
                listekle("Mavi oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox15.Location) || (pictureBox11.Location == pictureBox15.Location) || (pictureBox12.Location == pictureBox15.Location) || (pictureBox13.Location == pictureBox15.Location))
            {
                pictureBox15.Location = new Point(570, 515);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 0;
                listekle("Mavi oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox16.Location) || (pictureBox11.Location == pictureBox16.Location) || (pictureBox12.Location == pictureBox16.Location) || (pictureBox13.Location == pictureBox16.Location))
            {
                pictureBox16.Location = new Point(513, 574);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 6;
                listekle("Mavi oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox17.Location) || (pictureBox11.Location == pictureBox17.Location) || (pictureBox12.Location == pictureBox17.Location) || (pictureBox13.Location == pictureBox17.Location))
            {
                pictureBox17.Location = new Point(570, 577);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 4;
                listekle("Mavi oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox18.Location) || (pictureBox11.Location == pictureBox18.Location) || (pictureBox12.Location == pictureBox18.Location) || (pictureBox13.Location == pictureBox18.Location))
            {
                pictureBox18.Location = new Point(12, 514);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 6;
                listekle("Mavi oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox19.Location) || (pictureBox11.Location == pictureBox19.Location) || (pictureBox12.Location == pictureBox19.Location) || (pictureBox13.Location == pictureBox19.Location))
            {
                pictureBox19.Location = new Point(68, 515);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 2;
                listekle("Mavi oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox20.Location) || (pictureBox11.Location == pictureBox20.Location) || (pictureBox12.Location == pictureBox20.Location) || (pictureBox13.Location == pictureBox20.Location))
            {
                pictureBox20.Location = new Point(13, 576);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 4;
                listekle("Mavi oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox10.Location == pictureBox21.Location) || (pictureBox11.Location == pictureBox21.Location) || (pictureBox12.Location == pictureBox21.Location) || (pictureBox13.Location == pictureBox21.Location))
            {
                pictureBox21.Location = new Point(68, 575);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 0;
                listekle("Mavi oyuncu Sarı oyuncunun taşını yedi");
            }
        }

        private void yeşilye()
        {
            if ((pictureBox15.Location == pictureBox5.Location) || (pictureBox14.Location == pictureBox5.Location) || (pictureBox17.Location == pictureBox5.Location) || (pictureBox16.Location == pictureBox5.Location))
            {
                pictureBox5.Location = new Point(69, 63);
                redtaskon = 0;
                startred = false;
                redbitis = 2;
                listekle("Yeşil oyuncu Kırmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox4.Location) || (pictureBox14.Location == pictureBox4.Location) || (pictureBox17.Location == pictureBox4.Location) || (pictureBox16.Location == pictureBox4.Location))
            {
                pictureBox4.Location = new Point(12, 65);
                redtaskon = 0;
                startred = false;
                redbitis = 0;
                listekle("Yeşil oyuncu Kırmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox3.Location) || (pictureBox14.Location == pictureBox3.Location) || (pictureBox17.Location == pictureBox3.Location) || (pictureBox16.Location == pictureBox3.Location))
            {
                pictureBox3.Location = new Point(69, 10);
                redtaskon = 0;
                startred = false;
                redbitis = 6;
                listekle("Yeşil oyuncu Kırmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox2.Location) || (pictureBox14.Location == pictureBox2.Location) || (pictureBox17.Location == pictureBox2.Location) || (pictureBox16.Location == pictureBox2.Location))
            {
                pictureBox2.Location = new Point(12, 12);
                redtaskon = 0;
                startred = false;
                redbitis = 4;
                listekle("Yeşil oyuncu Kırmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox10.Location) || (pictureBox14.Location == pictureBox10.Location) || (pictureBox17.Location == pictureBox10.Location) || (pictureBox16.Location == pictureBox10.Location))
            {
                pictureBox10.Location = new Point(511, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 0;
                listekle("Yeşil oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox11.Location) || (pictureBox14.Location == pictureBox11.Location) || (pictureBox17.Location == pictureBox11.Location) || (pictureBox16.Location == pictureBox11.Location))
            {
                pictureBox11.Location = new Point(570, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 4;
                listekle("Yeşil oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox12.Location) || (pictureBox14.Location == pictureBox12.Location) || (pictureBox17.Location == pictureBox12.Location) || (pictureBox16.Location == pictureBox12.Location))
            {
                pictureBox12.Location = new Point(511, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 2;
                listekle("Yeşil oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox13.Location) || (pictureBox14.Location == pictureBox13.Location) || (pictureBox17.Location == pictureBox13.Location) || (pictureBox16.Location == pictureBox13.Location))
            {
                pictureBox13.Location = new Point(570, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 6;
                listekle("Yeşil oyuncu Mavi oyuncunun taşını yedi");
            }

            else if ((pictureBox15.Location == pictureBox18.Location) || (pictureBox14.Location == pictureBox18.Location) || (pictureBox17.Location == pictureBox18.Location) || (pictureBox16.Location == pictureBox18.Location))
            {
                pictureBox18.Location = new Point(12, 514);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 6;
                listekle("Yeşil oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox19.Location) || (pictureBox14.Location == pictureBox19.Location) || (pictureBox17.Location == pictureBox19.Location) || (pictureBox16.Location == pictureBox19.Location))
            {
                pictureBox19.Location = new Point(68, 515);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 2;
                listekle("Yeşil oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox20.Location) || (pictureBox14.Location == pictureBox20.Location) || (pictureBox17.Location == pictureBox20.Location) || (pictureBox16.Location == pictureBox20.Location))
            {
                pictureBox20.Location = new Point(13, 576);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 4;
                listekle("Yeşil oyuncu Sarı oyuncunun taşını yedi");
            }
            else if ((pictureBox15.Location == pictureBox21.Location) || (pictureBox14.Location == pictureBox21.Location) || (pictureBox17.Location == pictureBox21.Location) || (pictureBox16.Location == pictureBox21.Location))
            {
                pictureBox21.Location = new Point(68, 575);
                yellowtaskon = 0;
                startyellow = false;
                yellowbitis = 0;
                listekle("Yeşil oyuncu Sarı oyuncunun taşını yedi");
            }

        }

        private void sarıye()
        {
            if ((pictureBox18.Location == pictureBox3.Location) || (pictureBox19.Location == pictureBox3.Location) || (pictureBox20.Location == pictureBox3.Location) || (pictureBox21.Location == pictureBox3.Location))
            {
                pictureBox3.Location = new Point(69, 10);
                redtaskon = 0;
                startred = false;
                redbitis = 6;
                listekle("Sarı oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox5.Location) || (pictureBox19.Location == pictureBox5.Location) || (pictureBox20.Location == pictureBox5.Location) || (pictureBox21.Location == pictureBox5.Location))
            {
                pictureBox5.Location = new Point(69, 63);
                redtaskon = 0;
                startred = false;
                redbitis = 2;
                listekle("Sarı oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox2.Location) || (pictureBox19.Location == pictureBox2.Location) || (pictureBox20.Location == pictureBox2.Location) || (pictureBox21.Location == pictureBox2.Location))
            {
                pictureBox2.Location = new Point(12, 12);
                redtaskon = 0;
                startred = false;
                redbitis = 4;
                listekle("Sarı oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox4.Location) || (pictureBox19.Location == pictureBox4.Location) || (pictureBox20.Location == pictureBox4.Location) || (pictureBox21.Location == pictureBox4.Location))
            {
                pictureBox4.Location = new Point(12, 65);
                redtaskon = 0;
                startred = false;
                redbitis = 0;
                listekle("Sarı oyuncu Kızmızı oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox10.Location) || (pictureBox19.Location == pictureBox10.Location) || (pictureBox20.Location == pictureBox10.Location) || (pictureBox21.Location == pictureBox10.Location))
            {
                pictureBox10.Location = new Point(511, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 0;
                listekle("Sarı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox11.Location) || (pictureBox19.Location == pictureBox11.Location) || (pictureBox20.Location == pictureBox11.Location) || (pictureBox21.Location == pictureBox11.Location))
            {
                pictureBox11.Location = new Point(570, 8);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 4;
                listekle("Sarı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox12.Location) || (pictureBox19.Location == pictureBox12.Location) || (pictureBox20.Location == pictureBox12.Location) || (pictureBox21.Location == pictureBox12.Location))
            {
                pictureBox12.Location = new Point(511, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 2;
                listekle("Sarı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox13.Location) || (pictureBox19.Location == pictureBox13.Location) || (pictureBox20.Location == pictureBox13.Location) || (pictureBox21.Location == pictureBox13.Location))
            {
                pictureBox13.Location = new Point(570, 61);
                bluetaskon = 0;
                startblue = false;
                bluebitis = 6;
                listekle("Sarı oyuncu Mavi oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox14.Location) || (pictureBox19.Location == pictureBox14.Location) || (pictureBox20.Location == pictureBox14.Location) || (pictureBox21.Location == pictureBox14.Location))
            {
                pictureBox14.Location = new Point(513, 517);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 2;
                listekle("Sarı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox15.Location) || (pictureBox19.Location == pictureBox15.Location) || (pictureBox20.Location == pictureBox15.Location) || (pictureBox21.Location == pictureBox15.Location))
            {
                pictureBox15.Location = new Point(570, 515);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 0;
                listekle("Sarı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox16.Location) || (pictureBox19.Location == pictureBox16.Location) || (pictureBox20.Location == pictureBox16.Location) || (pictureBox21.Location == pictureBox16.Location))
            {
                pictureBox16.Location = new Point(513, 574);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 6;
                listekle("Sarı oyuncu Yeşil oyuncunun taşını yedi");
            }
            else if ((pictureBox18.Location == pictureBox17.Location) || (pictureBox19.Location == pictureBox17.Location) || (pictureBox20.Location == pictureBox17.Location) || (pictureBox21.Location == pictureBox17.Location))
            {
                pictureBox17.Location = new Point(570, 577);
                greentaskon = 0;
                startgreen = false;
                greenbitis = 4;
                listekle("Sarı oyuncu Yeşil oyuncunun taşını yedi");
            }

        }

        private void sonuc()
        {
            if (bitti_red != 4)
            {
                sıralama[3] = "4 - Kırmızı Yarışmacı";
            }
            else
            {
                if (bitti_blue != 4)
                {
                    sıralama[3] = "4 - Mavi Yarışmacı";
                }
                else
                {
                    if (bitti_yellow != 4)
                    {
                        sıralama[3] = "4 - Sarı Yarışmacı";
                    }
                    else
                    {
                        if (bitti_green != 4)
                        {
                            sıralama[3] = "4 - Yeşil Yarışmacı";
                        }
                    }
                }
            }

            MessageBox.Show(sıralama[0] + "\n" + sıralama[1] + "\n" + sıralama[2] + "\n" + sıralama[3], "OYUN BİTTİ");
            timer3.Enabled = true;
            button9.Visible = true;
        }

        /*********************************************************************************************************************************/

        int bitti_red = 0;
        int bitti_blue = 0;
        int bitti_yellow = 0;
        int bitti_green = 0;

        void start_red()
        {
            startred = true;

            if (pictureBox4.Location.X == 12 && pictureBox4.Location.Y == 65)
            {
                pictureBox4.Location = new Point(konx[0], kony[0]);
                listekle("Kırmızı Oyuncu 1. Taşını Çıkardı");
                kırmızıye();
            }
            if (pictureBox5.Location.X == 69 && pictureBox5.Location.Y == 63 && pictureBox4.Location.X == konredx[3] && pictureBox4.Location.Y == konredy[3])
            {
                pictureBox5.Location = new Point(konx[0], kony[0]);
                listekle("Kırmızı Oyuncu 2. Taşını Çıkardı");
                kırmızıye();
            }
            if (pictureBox2.Location.X == 12 && pictureBox2.Location.Y == 12 && pictureBox5.Location.X == konredx[2] && pictureBox5.Location.Y == konredy[2])
            {
                pictureBox2.Location = new Point(konx[0], kony[0]);
                listekle("Kırmızı Oyuncu 3. Taşını Çıkardı");
                kırmızıye();
            }
            if (pictureBox3.Location.X == 69 && pictureBox3.Location.Y == 10 && pictureBox2.Location.X == konredx[1] && pictureBox2.Location.Y == konredy[1])
            {
                pictureBox3.Location = new Point(konx[0], kony[0]);
                listekle("Kırmızı Oyuncu 4. Taşını Çıkardı");
                kırmızıye();
            }
        }
        void next_red()
        {
            redtaskon += tıkla;
            //4. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 6)
            {
                pictureBox3.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }
            if (redtaskon > 39 && redbitis == 6)
            {
                redtaskon -= 40;
                redbitis = 7;
            }
            if (redbitis == 7)
            {
                if (redtaskon >= 0)
                {
                    pictureBox3.Location = new Point(konredx[0], konredy[0]);
                    redtaskon = 0;
                    redbitis = 8;
                    bitti_red = 4;
                    startred = false;
                    listekle("Kırmızı Yarışmacı 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 2; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 2)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Kırmızı Yarışmacı";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Kırmızı Yarışmacı";
                                break;
                            }
                        }

                        /*if (sıralama[i] == "0")
                        {
                            sıralama[i] = i.ToString()+"- Kırmızı Oyuncu";
                            break;
                        }
                        if (i == 3 && sıralama[i] != "0")
                        {
                            sonuc();
                        }*/
                    }
                }
                else
                    pictureBox3.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //3. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 4)
            {
                pictureBox2.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }
            if (redtaskon > 39 && redbitis == 4)
            {
                redtaskon -= 40;
                redbitis = 5;
            }
            if (redbitis == 5)
            {
                if (redtaskon >= 1)
                {
                    pictureBox2.Location = new Point(konredx[1], konredy[1]);
                    redtaskon = 0;
                    redbitis = 6;
                    startred = false;
                    listekle("Kırmızı Yarışmacı 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox2.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //2. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 2)
            {
                pictureBox5.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }
            if (redtaskon > 39 && redbitis == 2)
            {
                redtaskon -= 40;
                redbitis = 3;
            }
            if (redbitis == 3)
            {
                if (redtaskon >= 2)
                {
                    pictureBox5.Location = new Point(konredx[2], konredy[2]);
                    redtaskon = 0;
                    redbitis = 4;
                    startred = false;
                    listekle("Kırmızı Yarışmacı 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox5.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //1. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 0)
            {
                pictureBox4.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }
            if (redtaskon > 39 && redbitis == 0)
            {
                redtaskon -= 40;
                redbitis = 1;
            }
            if (redbitis == 1)
            {
                if (redtaskon >= 3)
                {
                    pictureBox4.Location = new Point(konredx[3], konredy[3]);
                    redtaskon = 0;
                    redbitis = 2;
                    startred = false;
                    listekle("Kırmızı Yarışmacı 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox4.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //button2.Enabled = false;
            //button4.Enabled = true;
            //oto = 0;
            //timer1.Enabled = true;
        }
        void back_red()
        {
            if (startred == true && puan >= 2)
            {
                redtaskon -= 2;
            }

            //4. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 6)
            {
                pictureBox3.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }
            if (redtaskon > 39 && redbitis == 6)
            {
                redtaskon -= 40;
                redbitis = 7;
            }
            if (redbitis == 7)
            {
                if (redtaskon >= 0)
                {
                    pictureBox3.Location = new Point(konredx[0], konredy[0]);
                    redtaskon = 0;
                    redbitis = 8;
                    startred = false;
                    listekle("Kırmızı Oyuncu 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 3; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 3)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Kırmızı Oyuncu";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Kırmızı Oyuncu";
                                break;
                            }
                        }

                        /*if (sıralama[i] == "0")
                        {
                            sıralama[i] = i.ToString()+"- Kırmızı Oyuncu";
                            break;
                        }
                        if (i == 3 && sıralama[i] != "0")
                        {
                            sonuc();
                        }*/
                    }
                }
                else
                    pictureBox3.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //3. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 4)
            {
                pictureBox2.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }
            if (redtaskon > 39 && redbitis == 4)
            {
                redtaskon -= 40;
                redbitis = 5;
            }
            if (redbitis == 5)
            {
                if (redtaskon >= 1)
                {
                    pictureBox2.Location = new Point(konredx[1], konredy[1]);
                    redtaskon = 0;
                    redbitis = 6;
                    startred = false;
                    listekle("Kırmızı Oyuncu 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox2.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //2. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 2)
            {
                pictureBox5.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }

            if (redtaskon > 39 && redbitis == 2)
            {
                redtaskon -= 40;
                redbitis = 3;
            }
            if (redbitis == 3)
            {
                if (redtaskon >= 2)
                {
                    pictureBox5.Location = new Point(konredx[2], konredy[2]);
                    redtaskon = 0;
                    redbitis = 4;
                    startred = false;
                    listekle("Kırmızı Oyuncu 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox5.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //1. kırmızı taş için
            if (redtaskon <= 39 && redbitis == 0)
            {
                pictureBox4.Location = new Point(konx[redtaskon], kony[redtaskon]);
                kırmızıye();
            }

            if (redtaskon > 39 && redbitis == 0)
            {
                redtaskon -= 40;
                redbitis = 1;
            }
            if (redbitis == 1)
            {
                if (redtaskon >= 3)
                {
                    pictureBox4.Location = new Point(konredx[3], konredy[3]);
                    redtaskon = 0;
                    redbitis = 2;
                    startred = false;
                    listekle("Kırmızı Oyuncu 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox4.Location = new Point(konredx[redtaskon], konredy[redtaskon]);
            }

            //button2.Enabled = false;
            //button4.Enabled = true;
            //oto = 0;
            //timer1.Enabled = true;
        }

        void start_blue()
        {
            if (Btn_A.Text == lbldogru.Text || Btn_B.Text == lbldogru.Text || Btn_C.Text == lbldogru.Text || Btn_D.Text == lbldogru.Text)
            {
                startblue = true;
            }
            else
            {
                startblue = false;
            }

            if (pictureBox10.Location.X == 511 && pictureBox10.Location.Y == 8)
            {
                pictureBox10.Location = new Point(mavikonx[0], mavikony[0]);
                listekle("Mavi Oyuncu 1. Taşını Çıkardı");
                maviye();
            }
            if (pictureBox12.Location.X == 511 && pictureBox12.Location.Y == 61 && pictureBox10.Location.X == konbluex[3] && pictureBox10.Location.Y == konbluey[3])
            {
                pictureBox12.Location = new Point(mavikonx[0], mavikony[0]);
                listekle("Mavi Oyuncu 2. Taşını Çıkardı");
                maviye();
            }
            if (pictureBox11.Location.X == 570 && pictureBox11.Location.Y == 8 && pictureBox12.Location.X == konbluex[2] && pictureBox12.Location.Y == konbluey[2])
            {
                pictureBox11.Location = new Point(mavikonx[0], mavikony[0]);
                listekle("Mavi Oyuncu 3. Taşını Çıkardı");
                maviye();
            }
            if (pictureBox13.Location.X == 570 && pictureBox13.Location.Y == 61 && pictureBox11.Location.X == konbluex[1] && pictureBox11.Location.Y == konbluey[1])
            {
                pictureBox13.Location = new Point(mavikonx[0], mavikony[0]);
                listekle("Mavi Oyuncu 4. Taşını Çıkardı");
                maviye();
            }
        }
        void next_blue()
        {
            bluetaskon += tıkla;

            //4. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 6)
            {
                pictureBox13.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 6)
            {
                bluetaskon -= 40;
                bluebitis = 7;
            }
            if (bluebitis == 7)
            {
                if (bluetaskon >= 0)
                {
                    pictureBox13.Location = new Point(konbluex[0], konbluey[0]);
                    bluetaskon = 0;
                    bluebitis = 8;
                    bitti_blue = 4;
                    startblue = false;
                    listekle("Mavi Yarışmacı 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 2; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 2)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Mavi Yarışmacı";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Mavi Yarışmacı";
                                break;
                            }
                        }
                    }
                }
                else
                    pictureBox13.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }

            //3. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 4)
            {
                pictureBox11.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 4)
            {
                bluetaskon -= 40;
                bluebitis = 5;
            }
            if (bluebitis == 5)
            {
                if (bluetaskon >= 2)
                {
                    pictureBox11.Location = new Point(konbluex[1], konbluey[1]);
                    bluetaskon = 0;
                    bluebitis = 6;
                    startblue = false;
                    listekle("Mavi Yarışmacı 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox11.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }

            //2. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 2)
            {
                pictureBox12.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 2)
            {
                bluetaskon -= 40;
                bluebitis = 3;
            }
            if (bluebitis == 3)
            {
                if (bluetaskon >= 2)
                {
                    pictureBox12.Location = new Point(konbluex[2], konbluey[2]);
                    bluetaskon = 0;
                    bluebitis = 4;
                    startblue = false;
                    listekle("Mavi Yarışmacı 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox12.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }

            //1. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 0)
            {
                pictureBox10.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 0)
            {
                bluetaskon -= 40;
                bluebitis = 1;
            }
            if (bluebitis == 1)
            {
                if (bluetaskon >= 3)
                {
                    pictureBox10.Location = new Point(konbluex[3], konbluey[3]);
                    bluetaskon = 0;
                    bluebitis = 2;
                    startblue = false;
                    listekle("Mavi Yarışmacı 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox10.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }
            //button3.Enabled = false;
            //button6.Enabled = true;
        }
        void back_blue()
        {
            if (startblue == true && puan_2 >= 2)
            {
                bluetaskon -= 2;
            }

            //4. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 6)
            {
                pictureBox13.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 6)
            {
                bluetaskon -= 40;
                bluebitis = 7;
            }
            if (bluebitis == 7)
            {
                if (bluetaskon >= 0)
                {
                    pictureBox13.Location = new Point(konbluex[0], konbluey[0]);
                    bluetaskon = 0;
                    bluebitis = 8;
                    startblue = false;
                    listekle("Mavi Oyuncu 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 3; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 3)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Mavi Oyuncu";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Mavi Oyuncu";
                                break;
                            }
                        }
                    }
                }
                else
                    pictureBox13.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }

            //3. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 4)
            {
                pictureBox11.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 4)
            {
                bluetaskon -= 40;
                bluebitis = 5;
            }
            if (bluebitis == 5)
            {
                if (bluetaskon >= 2)
                {
                    pictureBox11.Location = new Point(konbluex[1], konbluey[1]);
                    bluetaskon = 0;
                    bluebitis = 6;
                    startblue = false;
                    listekle("Mavi Oyuncu 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox11.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }

            //2. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 2)
            {
                pictureBox12.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 2)
            {
                bluetaskon -= 40;
                bluebitis = 3;
            }
            if (bluebitis == 3)
            {
                if (bluetaskon >= 2)
                {
                    pictureBox12.Location = new Point(konbluex[2], konbluey[2]);
                    bluetaskon = 0;
                    bluebitis = 4;
                    startblue = false;
                    listekle("Mavi Oyuncu 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox12.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }

            //1. mavi taş için
            if (bluetaskon <= 39 && bluebitis == 0)
            {
                pictureBox10.Location = new Point(mavikonx[bluetaskon], mavikony[bluetaskon]);
                maviye();
            }
            if (bluetaskon > 39 && bluebitis == 0)
            {
                bluetaskon -= 40;
                bluebitis = 1;
            }
            if (bluebitis == 1)
            {
                if (bluetaskon >= 3)
                {
                    pictureBox10.Location = new Point(konbluex[3], konbluey[3]);
                    bluetaskon = 0;
                    bluebitis = 2;
                    startblue = false;
                    listekle("Mavi Oyuncu 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox10.Location = new Point(konbluex[bluetaskon], konbluey[bluetaskon]);
            }
            //button3.Enabled = false;
            //button6.Enabled = true;
        }

        void start_yellow()
        {
            if (Btn_A.Text == lbldogru.Text || Btn_B.Text == lbldogru.Text || Btn_C.Text == lbldogru.Text || Btn_D.Text == lbldogru.Text)
            {
                startyellow = true;
            }
            else
            {
                startyellow = false;
            }

            if (pictureBox21.Location.X == 68 && pictureBox21.Location.Y == 575)
            {
                pictureBox21.Location = new Point(sarıkonx[0], sarıkony[0]);
                listekle("Sarı Oyuncu 1. Taşını Çıkardı");
                sarıye();
            }
            if (pictureBox19.Location.X == 68 && pictureBox19.Location.Y == 515 && pictureBox21.Location.X == konyellowx[3] && pictureBox21.Location.Y == konyellowy[3])
            {
                pictureBox19.Location = new Point(sarıkonx[0], sarıkony[0]);
                listekle("Sarı Oyuncu 2. Taşını Çıkardı");
                sarıye();
            }
            if (pictureBox20.Location.X == 13 && pictureBox20.Location.Y == 576 && pictureBox19.Location.X == konyellowx[2] && pictureBox19.Location.Y == konyellowy[2])
            {
                pictureBox20.Location = new Point(sarıkonx[0], sarıkony[0]);
                listekle("Sarı Oyuncu 3. Taşını Çıkardı");
                sarıye();
            }
            if (pictureBox18.Location.X == 12 && pictureBox18.Location.Y == 514 && pictureBox20.Location.X == konyellowx[1] && pictureBox20.Location.Y == konyellowy[1])
            {
                pictureBox18.Location = new Point(sarıkonx[0], sarıkony[0]);
                listekle("Sarı Oyuncu 4. Taşını Çıkardı");
                sarıye();
            }
        }
        void next_yellow()
        {
            yellowtaskon += tıkla;

            //4. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 6)
            {
                pictureBox18.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 6)
            {
                yellowtaskon -= 40;
                yellowbitis = 7;
            }
            if (yellowbitis == 7)
            {
                if (yellowtaskon >= 0)
                {
                    pictureBox18.Location = new Point(konyellowx[0], konyellowy[0]);
                    yellowtaskon = 0;
                    yellowbitis = 8;
                    bitti_yellow = 4;
                    startyellow = false;
                    listekle("Sarı Yarışmacı 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 2; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 2)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Sarı Yarışmacı";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Sarı Yarışmacı";
                                break;
                            }
                        }
                    }
                }
                else
                    pictureBox18.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }

            //3. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 4)
            {
                pictureBox20.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 4)
            {
                yellowtaskon -= 40;
                yellowbitis = 5;
            }
            if (yellowbitis == 5)
            {
                if (yellowtaskon >= 1)
                {
                    pictureBox20.Location = new Point(konyellowx[1], konyellowy[1]);
                    yellowtaskon = 0;
                    yellowbitis = 6;
                    startyellow = false;
                    listekle("Sarı Yarışmacı 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox20.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }

            //2. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 2)
            {
                pictureBox19.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 2)
            {
                yellowtaskon -= 40;
                yellowbitis = 3;
            }
            if (yellowbitis == 3)
            {
                if (yellowtaskon >= 2)
                {
                    pictureBox19.Location = new Point(konyellowx[2], konyellowy[2]);
                    yellowtaskon = 0;
                    yellowbitis = 4;
                    startyellow = false;
                    listekle("Sarı Yarışmacı 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox19.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }

            //1. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 0)
            {
                pictureBox21.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 0)
            {
                yellowtaskon -= 40;
                yellowbitis = 1;
            }
            if (yellowbitis == 1)
            {
                if (yellowtaskon >= 3)
                {
                    pictureBox21.Location = new Point(konyellowx[3], konyellowy[3]);
                    yellowtaskon = 0;
                    yellowbitis = 2;
                    startyellow = false;
                    listekle("Sarı Yarışmacı 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox21.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }
        }
        void back_yellow()
        {
            if (startyellow == true && puan_3 >= 2)
            {
                yellowtaskon -= 2;
            }


            //4. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 6)
            {
                pictureBox18.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 6)
            {
                yellowtaskon -= 40;
                yellowbitis = 7;
            }
            if (yellowbitis == 7)
            {
                if (yellowtaskon >= 0)
                {
                    pictureBox18.Location = new Point(konyellowx[0], konyellowy[0]);
                    yellowtaskon = 0;
                    yellowbitis = 8;
                    startyellow = false;
                    listekle("Sarı Oyuncu 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 3; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 3)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Sarı Oyuncu";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Sarı Oyuncu";
                                break;
                            }
                        }
                    }
                }
                else
                    pictureBox18.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }

            //3. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 4)
            {
                pictureBox20.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 4)
            {
                yellowtaskon -= 40;
                yellowbitis = 5;
            }
            if (yellowbitis == 5)
            {
                if (yellowtaskon >= 1)
                {
                    pictureBox20.Location = new Point(konyellowx[1], konyellowy[1]);
                    yellowtaskon = 0;
                    yellowbitis = 6;
                    startyellow = false;
                    listekle("Sarı Oyuncu 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox20.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }

            //2. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 2)
            {
                pictureBox19.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 2)
            {
                yellowtaskon -= 40;
                yellowbitis = 3;
            }
            if (yellowbitis == 3)
            {
                if (yellowtaskon >= 2)
                {
                    pictureBox19.Location = new Point(konyellowx[2], konyellowy[2]);
                    yellowtaskon = 0;
                    yellowbitis = 4;
                    startyellow = false;
                    listekle("Sarı Oyuncu 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox19.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }

            //1. sarı taş için
            if (yellowtaskon <= 39 && yellowbitis == 0)
            {
                pictureBox21.Location = new Point(sarıkonx[yellowtaskon], sarıkony[yellowtaskon]);
                sarıye();
            }
            if (yellowtaskon > 39 && yellowbitis == 0)
            {
                yellowtaskon -= 40;
                yellowbitis = 1;
            }
            if (yellowbitis == 1)
            {
                if (yellowtaskon >= 3)
                {
                    pictureBox21.Location = new Point(konyellowx[3], konyellowy[3]);
                    yellowtaskon = 0;
                    yellowbitis = 2;
                    startyellow = false;
                    listekle("Sarı Oyuncu 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox21.Location = new Point(konyellowx[yellowtaskon], konyellowy[yellowtaskon]);
            }
        }

        void start_green()
        {
            if (Btn_A.Text == lbldogru.Text || Btn_B.Text == lbldogru.Text || Btn_C.Text == lbldogru.Text || Btn_D.Text == lbldogru.Text)
            {
                startgreen = true;
            }
            else
            {
                startgreen = false;
            }

            if (pictureBox15.Location.X == 570 && pictureBox15.Location.Y == 515)
            {
                pictureBox15.Location = new Point(yeşilkonx[0], yeşilkony[0]);
                listekle("Yeşil Oyuncu 1. Taşını Çıkardı");
                yeşilye();
            }
            if (pictureBox14.Location.X == 513 && pictureBox14.Location.Y == 517 && pictureBox15.Location.X == kongreenx[3] && pictureBox15.Location.Y == kongreeny[3])
            {
                pictureBox14.Location = new Point(yeşilkonx[0], yeşilkony[0]);
                listekle("Yeşil Oyuncu 2. Taşını Çıkardı");
                yeşilye();
            }
            if (pictureBox17.Location.X == 570 && pictureBox17.Location.Y == 577 && pictureBox14.Location.X == kongreenx[2] && pictureBox14.Location.Y == kongreeny[2])
            {
                pictureBox17.Location = new Point(yeşilkonx[0], yeşilkony[0]);
                listekle("Yeşil Oyuncu 3. Taşını Çıkardı");
                yeşilye();
            }
            if (pictureBox16.Location.X == 513 && pictureBox16.Location.Y == 574 && pictureBox17.Location.X == kongreenx[1] && pictureBox17.Location.Y == kongreeny[1])
            {
                pictureBox16.Location = new Point(yeşilkonx[0], yeşilkony[0]);
                listekle("Yeşil Oyuncu 4. Taşını Çıkardı");
                yeşilye();
            }
        }
        void next_green()
        {
            greentaskon += tıkla;

            //4. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 6)
            {
                pictureBox16.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 6)
            {
                greentaskon -= 40;
                greenbitis = 7;
            }
            if (greenbitis == 7)
            {
                if (greentaskon >= 0)
                {
                    pictureBox16.Location = new Point(kongreenx[0], kongreeny[0]);
                    greentaskon = 0;
                    greenbitis = 8;
                    bitti_green = 4;
                    startgreen = false;
                    listekle("Yeşil Yarışmacı 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 2; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 2)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Yeşil Yarışmacı";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Yeşil Yarışmacı";
                                break;
                            }
                        }
                    }
                }
                else
                    pictureBox16.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }

            //3. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 4)
            {
                pictureBox17.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 4)
            {
                greentaskon -= 40;
                greenbitis = 5;
            }
            if (greenbitis == 5)
            {
                if (greentaskon >= 1)
                {
                    pictureBox17.Location = new Point(kongreenx[1], kongreeny[1]);
                    greentaskon = 0;
                    greenbitis = 6;
                    startgreen = false;
                    listekle("Yeşil Yarışmacı 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox17.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }

            //2. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 2)
            {
                pictureBox14.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 2)
            {
                greentaskon -= 40;
                greenbitis = 3;
            }
            if (greenbitis == 3)
            {
                if (greentaskon >= 2)
                {
                    pictureBox14.Location = new Point(kongreenx[2], kongreeny[2]);
                    greentaskon = 0;
                    greenbitis = 4;
                    startgreen = false;
                    listekle("Yeşil Yarışmacı 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox14.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }

            //1. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 0)
            {
                pictureBox15.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 0)
            {
                greentaskon -= 40;
                greenbitis = 1;
            }
            if (greenbitis == 1)
            {
                if (greentaskon >= 3)
                {
                    pictureBox15.Location = new Point(kongreenx[3], kongreeny[3]);
                    greentaskon = 0;
                    greenbitis = 2;
                    startgreen = false;
                    listekle("Yeşil Yarışmacı 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox15.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }
        }
        void back_green()
        {
            if (startgreen == true && puan_4 >= 2)
            {
                greentaskon -= 2;
            }

            //4. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 6)
            {
                pictureBox16.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 6)
            {
                greentaskon -= 40;
                greenbitis = 7;
            }
            if (greenbitis == 7)
            {
                if (greentaskon >= 0)
                {
                    pictureBox16.Location = new Point(kongreenx[0], kongreeny[0]);
                    greentaskon = 0;
                    greenbitis = 8;
                    startgreen = false;
                    listekle("Yeşil Oyuncu 4. Taşını Yuvaya Götürdü");
                    for (int i = 0; i <= 3; i++)
                    {
                        if (sıralama[i] == "0")
                        {
                            if (i == 3)
                            {
                                sıralama[i] = (i + 1).ToString() + "- Yeşil Oyuncu";
                                sonuc();
                                break;
                            }
                            else
                            {
                                sıralama[i] = (i + 1).ToString() + "- Yeşil Oyuncu";
                                break;
                            }
                        }
                    }
                }
                else
                    pictureBox16.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }

            //3. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 4)
            {
                pictureBox17.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 4)
            {
                greentaskon -= 40;
                greenbitis = 5;
            }
            if (greenbitis == 5)
            {
                if (greentaskon >= 1)
                {
                    pictureBox17.Location = new Point(kongreenx[1], kongreeny[1]);
                    greentaskon = 0;
                    greenbitis = 6;
                    startgreen = false;
                    listekle("Yeşil Oyuncu 3. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox17.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }

            //2. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 2)
            {
                pictureBox14.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 2)
            {
                greentaskon -= 40;
                greenbitis = 3;
            }
            if (greenbitis == 3)
            {
                if (greentaskon >= 2)
                {
                    pictureBox14.Location = new Point(kongreenx[2], kongreeny[2]);
                    greentaskon = 0;
                    greenbitis = 4;
                    startgreen = false;
                    listekle("Yeşil Oyuncu 2. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox14.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }

            //1. yeşil taş için
            if (greentaskon <= 39 && greenbitis == 0)
            {
                pictureBox15.Location = new Point(yeşilkonx[greentaskon], yeşilkony[greentaskon]);
                yeşilye();
            }
            if (greentaskon > 39 && greenbitis == 0)
            {
                greentaskon -= 40;
                greenbitis = 1;
            }
            if (greenbitis == 1)
            {
                if (greentaskon >= 3)
                {
                    pictureBox15.Location = new Point(kongreenx[3], kongreeny[3]);
                    greentaskon = 0;
                    greenbitis = 2;
                    startgreen = false;
                    listekle("Yeşil Oyuncu 1. Taşını Yuvaya Götürdü");
                }
                else
                    pictureBox15.Location = new Point(kongreenx[greentaskon], kongreeny[greentaskon]);
            }
        }


        void birinci_yarismaci_aktif()
        {
            if (bitti_blue == 4)
            {
                if (bitti_yellow != 4)
                {
                    //bir_yarismaci_aktif
                    Btn_redSor.Visible = false;
                    Btn_blueSor.Visible = false;
                    Btn_yellowSor.Visible = true;
                    Btn_greenSor.Visible = false;
                }
                else
                {
                    Btn_redSor.Visible = false;
                    Btn_blueSor.Visible = false;
                    Btn_yellowSor.Visible = false;
                    Btn_greenSor.Visible = true;
                }
            }
            //if (bitti_yellow == 4)
            //{
            //    //bir_yarismaci_aktif
            //    Btn_redSor.Visible = false;
            //    Btn_blueSor.Visible = false;
            //    Btn_yellowSor.Visible = false;
            //    Btn_greenSor.Visible = true;
            //}
            //if (bitti_green == 4)
            //{
            //    //bir_yarismaci_aktif
            //    Btn_redSor.Visible = true;
            //    Btn_blueSor.Visible = false;
            //    Btn_yellowSor.Visible = false;
            //    Btn_greenSor.Visible = false;
            //}
            else
            {
                Btn_redSor.Visible = false;
                Btn_blueSor.Visible = true;
                Btn_yellowSor.Visible = false;
                Btn_greenSor.Visible = false;
            }
        }
        void ikinci_yarismaci_aktif()
        {
            if (bitti_yellow == 4)
            {
                if (bitti_green != 4)
                {
                    //ikinci_yarismaci_aktif
                    Btn_redSor.Visible = false;
                    Btn_blueSor.Visible = false;
                    Btn_yellowSor.Visible = false;
                    Btn_greenSor.Visible = true;
                }
                else
                {
                    Btn_redSor.Visible = true;
                    Btn_blueSor.Visible = false;
                    Btn_yellowSor.Visible = false;
                    Btn_greenSor.Visible = false;
                }
            }
            //if (bitti_green == 4)
            //{
            //    //ikinci_yarismaci_aktif
            //    Btn_redSor.Visible = true;
            //    Btn_blueSor.Visible = false;
            //    Btn_yellowSor.Visible = false;
            //    Btn_greenSor.Visible = false;
            //}
            //if (bitti_red == 4)
            //{
            //    //ikinci_yarismaci_aktif
            //    Btn_redSor.Visible = false;
            //    Btn_blueSor.Visible = false;
            //    Btn_yellowSor.Visible = true;
            //    Btn_greenSor.Visible = false;
            //}
            else
            {
                Btn_redSor.Visible = false;
                Btn_blueSor.Visible = false;
                Btn_yellowSor.Visible = true;
                Btn_greenSor.Visible = false;
            }
        }
        void ucuncu_yarismaci_aktif()
        {
            if (bitti_green == 4)
            {
                if (bitti_red != 4)
                {
                    //ucuncu_yarismaci_aktif
                    Btn_redSor.Visible = true;
                    Btn_blueSor.Visible = false;
                    Btn_yellowSor.Visible = false;
                    Btn_greenSor.Visible = false;
                }
                else
                {
                    Btn_redSor.Visible = false;
                    Btn_blueSor.Visible = true;
                    Btn_yellowSor.Visible = false;
                    Btn_greenSor.Visible = false;
                }
            }
            //if (bitti_red == 4)
            //{
            //    //ikinci_yarismaci_aktif
            //    Btn_redSor.Visible = false;
            //    Btn_blueSor.Visible = true;
            //    Btn_yellowSor.Visible = false;
            //    Btn_greenSor.Visible = false;
            //}
            //if (bitti_blue == 4)
            //{
            //    //bir_yarismaci_aktif
            //    Btn_redSor.Visible = false;
            //    Btn_blueSor.Visible = false;
            //    Btn_yellowSor.Visible = true;
            //    Btn_greenSor.Visible = false;
            //}
            else
            {
                Btn_redSor.Visible = false;
                Btn_blueSor.Visible = false;
                Btn_yellowSor.Visible = false;
                Btn_greenSor.Visible = true;
            }
        }
        void dorduncu_yarismaci_aktif()
        {
            if (bitti_red == 4)
            {
                if (bitti_blue != 4)
                {
                    //dotduncu_yarismaci_aktif
                    Btn_redSor.Visible = false;
                    Btn_blueSor.Visible = true;
                    Btn_yellowSor.Visible = false;
                    Btn_greenSor.Visible = false;
                }
                else
                {
                    Btn_redSor.Visible = false;
                    Btn_blueSor.Visible = false;
                    Btn_yellowSor.Visible = true;
                    Btn_greenSor.Visible = false;
                }
            }
            //if (bitti_blue == 4)
            //{
            //    //bir_yarismaci_aktif
            //    Btn_redSor.Visible = false;
            //    Btn_blueSor.Visible = false;
            //    Btn_yellowSor.Visible = true;
            //    Btn_greenSor.Visible = false;
            //}
            //if (bitti_yellow == 4)
            //{
            //    //ikinci_yarismaci_aktif
            //    Btn_redSor.Visible = false;
            //    Btn_blueSor.Visible = false;
            //    Btn_yellowSor.Visible = false;
            //    Btn_greenSor.Visible = true;
            //}
            else
            {
                Btn_redSor.Visible = true;
                Btn_blueSor.Visible = false;
                Btn_yellowSor.Visible = false;
                Btn_greenSor.Visible = false;
            }
        }

        /**************************************Soru Paneli*********************************************/

        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Db_BilgiYarisması;Integrated Security=True");

        int tıkla = 0;
        int yarismaci = 0;

        private void Btn_Kolay_Click(object sender, EventArgs e)
        {
            tıkla = 1;
            zaman = 15;
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kolay order by NEWID()", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtsoru.Text = (oku["soru"].ToString());
                Btn_A.Text = (oku["a"].ToString());
                Btn_B.Text = (oku["b"].ToString());
                Btn_C.Text = (oku["c"].ToString());
                Btn_D.Text = (oku["d"].ToString());
                lbldogru.Text = (oku["dogru"].ToString());
            }
            baglan.Close();
            panel5.Visible = false;
            timer4.Enabled = true;

            Btn_A.Enabled = true;
            Btn_B.Enabled = true;
            Btn_C.Enabled = true;
            Btn_D.Enabled = true;
        }

        private void Btn_Orta_Click(object sender, EventArgs e)
        {
            tıkla = 2;
            zaman = 30;
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Orta order by NEWID()", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtsoru.Text = (oku["soru"].ToString());
                Btn_A.Text = (oku["a"].ToString());
                Btn_B.Text = (oku["b"].ToString());
                Btn_C.Text = (oku["c"].ToString());
                Btn_D.Text = (oku["d"].ToString());
                lbldogru.Text = (oku["dogru"].ToString());
            }
            baglan.Close();
            panel5.Visible = false;
            timer4.Enabled = true;

            Btn_A.Enabled = true;
            Btn_B.Enabled = true;
            Btn_C.Enabled = true;
            Btn_D.Enabled = true;
        }

        private void Btn_Zor_Click(object sender, EventArgs e)
        {
            tıkla = 3;
            zaman = 45;
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Zor order by NEWID()", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtsoru.Text = (oku["soru"].ToString());
                Btn_A.Text = (oku["a"].ToString());
                Btn_B.Text = (oku["b"].ToString());
                Btn_C.Text = (oku["c"].ToString());
                Btn_D.Text = (oku["d"].ToString());
                lbldogru.Text = (oku["dogru"].ToString());
            }
            baglan.Close();
            panel5.Visible = false;
            timer4.Enabled = true;

            Btn_A.Enabled = true;
            Btn_B.Enabled = true;
            Btn_C.Enabled = true;
            Btn_D.Enabled = true;
        }

        private void Btn_Problem_Click(object sender, EventArgs e)
        {
            tıkla = 4;
            zaman = 60;
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Problem order by NEWID()", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtsoru.Text = (oku["soru"].ToString());
                Btn_A.Text = (oku["a"].ToString());
                Btn_B.Text = (oku["b"].ToString());
                Btn_C.Text = (oku["c"].ToString());
                Btn_D.Text = (oku["d"].ToString());
                lbldogru.Text = (oku["dogru"].ToString());
            }
            baglan.Close();
            panel5.Visible = false;
            timer4.Enabled = true;

            Btn_A.Enabled = true;
            Btn_B.Enabled = true;
            Btn_C.Enabled = true;
            Btn_D.Enabled = true;
        }

        int puan_2 = 0;
        int sayaç_2 = 0;
        private void Btn_blueSor_Click(object sender, EventArgs e)
        {
            yarismaci = 2;
            start_blue(); // Mavi taş çıkarma
            panel5.Visible = true;
            sayaç_2++;
            Lbl_Soru2.Text = sayaç_2.ToString();
            Lbl_Süre2.Text = "0";
            //zaman = 20;
            //timer4.Enabled = true;
        }

        int puan_3 = 0;
        int sayaç_3 = 0;
        private void Btn_yellowSor_Click(object sender, EventArgs e)
        {
            yarismaci = 3;
            start_yellow(); // Sarı taş çıkarma
            panel5.Visible = true;
            sayaç_3++;
            Lbl_Soru3.Text = sayaç_3.ToString();
            Lbl_Süre3.Text = "0";
            //zaman = 20;
            //timer4.Enabled = true;
        }

        int puan_4 = 0;
        int sayaç_4 = 0;
        private void Btn_greenSor_Click(object sender, EventArgs e)
        {
            yarismaci = 4;
            start_green(); // Yeşil taş çıkarma
            panel5.Visible = true;
            sayaç_4++;
            Lbl_Soru4.Text = sayaç_4.ToString();
            Lbl_Süre4.Text = "0";
            //zaman = 20;
            //timer4.Enabled = true;
        }

        int sayaç = 0;
        int puan = 0;
        int zaman = 15;
        private void Btn_redSor_Click(object sender, EventArgs e)
        {
            yarismaci = 1;
            start_red(); // Kırmızı taş çıkarma
            panel5.Visible = true;
            sayaç++;
            lblsoru.Text = sayaç.ToString();
            lblsüre.Text = "0";
            //zaman = 20;
            //timer4.Enabled = true;         
        }

        private void Btn_A_Click(object sender, EventArgs e)
        {
            if (Btn_A.Text == lbldogru.Text)
            {
                if (yarismaci == 1)
                {
                    puan += tıkla;
                    lblpuan.Text = puan.ToString();

                    next_red();  // Kırmızı taş ileri

                    birinci_yarismaci_aktif();
                }

                if (yarismaci == 2)
                {
                    puan_2 += tıkla;
                    Lbl_Puan2.Text = puan_2.ToString();

                    next_blue();  // Mavi taş ileri

                    ikinci_yarismaci_aktif();
                }

                if (yarismaci == 3)
                {
                    puan_3 += tıkla;
                    Lbl_Puan3.Text = puan_3.ToString();

                    next_yellow();  // Sarı taş ileri

                    ucuncu_yarismaci_aktif();
                }

                if (yarismaci == 4)
                {
                    puan_4 += tıkla;
                    Lbl_Puan4.Text = puan_4.ToString();

                    next_green();  // Yeşil taş ileri

                    dorduncu_yarismaci_aktif();
                }
            }

            if (Btn_A.Text != lbldogru.Text)
            {
                if (yarismaci == 1)
                {
                    back_red();
                    puan = puan - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    lblpuan.Text = puan.ToString();

                    birinci_yarismaci_aktif();
                }

                if (yarismaci == 2)
                {
                    back_blue();
                    puan_2 = puan_2 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan2.Text = puan_2.ToString();

                    ikinci_yarismaci_aktif();
                }

                if (yarismaci == 3)
                {
                    back_yellow();
                    puan_3 = puan_3 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan3.Text = puan_3.ToString();

                    ucuncu_yarismaci_aktif();
                }

                if (yarismaci == 4)
                {
                    back_green();
                    puan_4 = puan_4 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan4.Text = puan_4.ToString();

                    dorduncu_yarismaci_aktif();
                }
            }
            timer4.Enabled = false;
            //Btn_redSor.Enabled = true;
            Btn_A.Enabled = false;
            Btn_B.Enabled = false;
            Btn_C.Enabled = false;
            Btn_D.Enabled = false;
        }

        private void Btn_B_Click(object sender, EventArgs e)
        {
            if (Btn_B.Text == lbldogru.Text)
            {
                if (yarismaci == 1)
                {
                    puan += tıkla;
                    lblpuan.Text = puan.ToString();

                    next_red();  // Kırmızı taş ileri

                    birinci_yarismaci_aktif();
                }

                if (yarismaci == 2)
                {
                    puan_2 += tıkla;
                    Lbl_Puan2.Text = puan_2.ToString();

                    next_blue();  // Mavi taş ileri

                    ikinci_yarismaci_aktif();
                }

                if (yarismaci == 3)
                {
                    puan_3 += tıkla;
                    Lbl_Puan3.Text = puan_3.ToString();

                    next_yellow();  // Sarı taş ileri

                    ucuncu_yarismaci_aktif();
                }

                if (yarismaci == 4)
                {
                    puan_4 += tıkla;
                    Lbl_Puan4.Text = puan_4.ToString();

                    next_green();  // Yeşil taş ileri

                    dorduncu_yarismaci_aktif();
                }
            }

            if (Btn_B.Text != lbldogru.Text)
            {
                if (yarismaci == 1)
                {
                    back_red();
                    puan = puan - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    lblpuan.Text = puan.ToString();

                    birinci_yarismaci_aktif();
                }

                if (yarismaci == 2)
                {
                    back_blue();
                    puan_2 = puan_2 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan2.Text = puan_2.ToString();

                    ikinci_yarismaci_aktif();
                }

                if (yarismaci == 3)
                {
                    back_yellow();
                    puan_3 = puan_3 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan3.Text = puan_3.ToString();

                    ucuncu_yarismaci_aktif();
                }

                if (yarismaci == 4)
                {
                    back_green();
                    puan_4 = puan_4 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan4.Text = puan_4.ToString();

                    dorduncu_yarismaci_aktif();
                }
            }
            timer4.Enabled = false;
            //Btn_redSor.Enabled = true;
            Btn_A.Enabled = false;
            Btn_B.Enabled = false;
            Btn_C.Enabled = false;
            Btn_D.Enabled = false;
        }

        private void Btn_C_Click(object sender, EventArgs e)
        {
            if (Btn_C.Text == lbldogru.Text)
            {
                if (yarismaci == 1)
                {
                    puan += tıkla;
                    lblpuan.Text = puan.ToString();

                    next_red();  // Kırmızı taş ileri

                    birinci_yarismaci_aktif();
                }

                if (yarismaci == 2)
                {
                    puan_2 += tıkla;
                    Lbl_Puan2.Text = puan_2.ToString();

                    next_blue();  // Mavi taş ileri

                    ikinci_yarismaci_aktif();
                }

                if (yarismaci == 3)
                {
                    puan_3 += tıkla;
                    Lbl_Puan3.Text = puan_3.ToString();

                    next_yellow();  // Sarı taş ileri

                    ucuncu_yarismaci_aktif();
                }

                if (yarismaci == 4)
                {
                    puan_4 += tıkla;
                    Lbl_Puan4.Text = puan_4.ToString();

                    next_green();  // Yeşil taş ileri

                    dorduncu_yarismaci_aktif();
                }
            }

            if (Btn_C.Text != lbldogru.Text)
            {
                if (yarismaci == 1)
                {
                    back_red();
                    puan = puan - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    lblpuan.Text = puan.ToString();

                    birinci_yarismaci_aktif();
                }

                if (yarismaci == 2)
                {
                    back_blue();
                    puan_2 = puan_2 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan2.Text = puan_2.ToString();

                    ikinci_yarismaci_aktif();
                }

                if (yarismaci == 3)
                {
                    back_yellow();
                    puan_3 = puan_3 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan3.Text = puan_3.ToString();

                    ucuncu_yarismaci_aktif();
                }

                if (yarismaci == 4)
                {
                    back_green();
                    puan_4 = puan_4 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan4.Text = puan_4.ToString();

                    dorduncu_yarismaci_aktif();
                }
            }
            timer4.Enabled = false;
            //Btn_redSor.Enabled = true;
            Btn_A.Enabled = false;
            Btn_B.Enabled = false;
            Btn_C.Enabled = false;
            Btn_D.Enabled = false;
        }

        private void Btn_D_Click(object sender, EventArgs e)
        {
            if (Btn_D.Text == lbldogru.Text)
            {
                if (yarismaci == 1)
                {
                    puan += tıkla;
                    lblpuan.Text = puan.ToString();

                    next_red();  // Kırmızı taş ileri

                    birinci_yarismaci_aktif();
                }

                if (yarismaci == 2)
                {
                    puan_2 += tıkla;
                    Lbl_Puan2.Text = puan_2.ToString();

                    next_blue();  // Mavi taş ileri

                    ikinci_yarismaci_aktif();
                }

                if (yarismaci == 3)
                {
                    puan_3 += tıkla;
                    Lbl_Puan3.Text = puan_3.ToString();

                    next_yellow();  // Sarı taş ileri

                    ucuncu_yarismaci_aktif();
                }

                if (yarismaci == 4)
                {
                    puan_4 += tıkla;
                    Lbl_Puan4.Text = puan_4.ToString();

                    next_green();  // Yeşil taş ileri

                    dorduncu_yarismaci_aktif();
                }
            }

            if (Btn_D.Text != lbldogru.Text)
            {
                if (yarismaci == 1)
                {
                    back_red();
                    puan = puan - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    lblpuan.Text = puan.ToString();

                    birinci_yarismaci_aktif();
                }

                if (yarismaci == 2)
                {
                    back_blue();
                    puan_2 = puan_2 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan2.Text = puan_2.ToString();

                    ikinci_yarismaci_aktif();
                }

                if (yarismaci == 3)
                {
                    back_yellow();
                    puan_3 = puan_3 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan3.Text = puan_3.ToString();

                    ucuncu_yarismaci_aktif();
                }

                if (yarismaci == 4)
                {
                    back_green();
                    puan_4 = puan_4 - 2;

                    MessageBox.Show("Dogru Cevap " + lbldogru.Text);
                    Lbl_Puan4.Text = puan_4.ToString();

                    dorduncu_yarismaci_aktif();
                }
            }
            timer4.Enabled = false;
            //Btn_redSor.Enabled = true;
            Btn_A.Enabled = false;
            Btn_B.Enabled = false;
            Btn_C.Enabled = false;
            Btn_D.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (yarismaci == 1)
            {
                zaman--;
                lblsüre.Text = zaman.ToString();

                if (zaman == 0)
                {
                    timer4.Enabled = false;
                    MessageBox.Show("Süre Bitti:(");

                    puan = puan - 1;
                    lblpuan.Text = puan.ToString();
                    back_red();
                    birinci_yarismaci_aktif();
                }
            }

            if (yarismaci == 2)
            {
                zaman--;
                Lbl_Süre2.Text = zaman.ToString();

                if (zaman == 0)
                {
                    timer4.Enabled = false;
                    MessageBox.Show("Süre Bitti:(");

                    puan_2 = puan_2 - 1;
                    Lbl_Puan2.Text = puan_2.ToString();
                    back_blue();
                    ikinci_yarismaci_aktif();
                }
            }

            if (yarismaci == 3)
            {
                zaman--;
                Lbl_Süre3.Text = zaman.ToString();

                if (zaman == 0)
                {
                    timer4.Enabled = false;
                    MessageBox.Show("Süre Bitti:(");

                    puan_3 = puan_3 - 1;
                    Lbl_Puan3.Text = puan_3.ToString();
                    back_yellow();
                    ucuncu_yarismaci_aktif();
                }
            }

            if (yarismaci == 4)
            {
                zaman--;
                Lbl_Süre4.Text = zaman.ToString();

                if (zaman == 0)
                {
                    timer4.Enabled = false;
                    MessageBox.Show("Süre Bitti:(");

                    puan_4 = puan_4 - 1;
                    Lbl_Puan4.Text = puan_4.ToString();
                    back_green();
                    dorduncu_yarismaci_aktif();
                }
            }
        }
    }
}