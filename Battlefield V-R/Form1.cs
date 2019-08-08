using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battlefield_V_R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            pictureBox3.Hide();
        }
        static Random random1 = new Random();
        //static Random randomASS = new Random();
        //static Random randomMED = new Random();
        //static Random randomMA = new Random();
        //static Random randomSN = new Random();
        private async void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //this.bunifuFlatButton3.Iconimage = Image.FromFile(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\CUBE-loading.gif");
            this.bunifuFlatButton3.Iconimage = Properties.Resources.CUBE_loading;
            pictureBox3.Show();
            await Task.Delay(5000);
            pictureBox3.Hide();
            //this.bunifuFlatButton3.Iconimage = Image.FromFile(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\perspective-dice-six-faces-random_385591.png");
            this.bunifuFlatButton3.Iconimage = Properties.Resources.perspective;
            string[] paths1 = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\Class\");
            
            List<string> images1 = paths1.ToList();
            
            pictureBoxClass.ImageLocation = paths1[random1.Next(0, 5)];
            if(bunifuiOSSwitch1.Value==true)
            {
                pictureBoxClass.Image = Properties.Resources.challeng;
                string[] pathsCH = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\CH\");
                List<string> imagesCH = pathsCH.ToList();

                pictureBoxWeapon.ImageLocation = pathsCH[random1.Next(0, 6)];
            }
            else if (bunifuiOSSwitch1.Value == false)
            {
                if (pictureBoxClass.ImageLocation.Contains("Ass.png"))
                {
                    string[] pathsASS = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\AS\");
                    List<string> imagesASS = pathsASS.ToList();

                    pictureBoxWeapon.ImageLocation = pathsASS[random1.Next(0, 12)];

                }
                if (pictureBoxClass.ImageLocation.Contains("Chall.jpg"))
                {
                    string[] pathsCH = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\CH\");
                    List<string> imagesCH = pathsCH.ToList();

                    pictureBoxWeapon.ImageLocation = pathsCH[random1.Next(0, 6)];

                }
                else if (pictureBoxClass.ImageLocation.Contains("Med.png"))
                {
                    string[] pathsMED = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\ME\");
                    List<string> imagesMED = pathsMED.ToList();

                    pictureBoxWeapon.ImageLocation = pathsMED[random1.Next(0, 11)];

                }
                else if (pictureBoxClass.ImageLocation.Contains("Sup.png"))
                {
                    string[] pathsMA = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\MA\");
                    List<string> imagesMA = pathsMA.ToList();
                    Random randomMA = new Random();
                    pictureBoxWeapon.ImageLocation = pathsMA[randomMA.Next(0, 13)];

                }
                else if (pictureBoxClass.ImageLocation.Contains("Sniper.png"))
                {
                    string[] pathsSN = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\SN\");
                    List<string> imagesSN = pathsSN.ToList();

                    pictureBoxWeapon.ImageLocation = pathsSN[random1.Next(0, 11)];


                }
                pictureBox3.Hide();
            }
            //if (pictureBoxClass.ImageLocation.Contains("Ass.png"))
            //{
            //    string[] pathsASS = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\AS\");
            //    List<string> imagesASS = pathsASS.ToList();
                
            //    pictureBoxWeapon.ImageLocation = pathsASS[random1.Next(0, 12)];

            //}
            //if(pictureBoxClass.ImageLocation.Contains("Chall.jpg"))
            //{
            //    string[] pathsCH = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\CH\");
            //    List<string> imagesCH = pathsCH.ToList();

            //    pictureBoxWeapon.ImageLocation = pathsCH[random1.Next(0, 6)];

            //}
            //else if (pictureBoxClass.ImageLocation.Contains("Med.png"))
            //{
            //    string[] pathsMED = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\ME\");
            //    List<string> imagesMED = pathsMED.ToList();
                
            //    pictureBoxWeapon.ImageLocation = pathsMED[random1.Next(0, 11)];

            //}
            //else if (pictureBoxClass.ImageLocation.Contains("Sup.png"))
            //{
            //    string[] pathsMA = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\MA\");
            //    List<string> imagesMA = pathsMA.ToList();
            //    Random randomMA = new Random();
            //    pictureBoxWeapon.ImageLocation = pathsMA[randomMA.Next(0, 13)];

            //}
            //else if (pictureBoxClass.ImageLocation.Contains("Sniper.png"))
            //{
            //    string[] pathsSN = Directory.GetFiles(@"C:\Users\vlad1\Source\Repos\Battlefield V-R\Battlefield V-R\Resources\SN\");
            //    List<string> imagesSN = pathsSN.ToList();
                
            //    pictureBoxWeapon.ImageLocation = pathsSN[random1.Next(0, 11)];
                
               
            //}
            //pictureBox3.Hide();
            
        }

        private void BunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {

        }
    }
}
