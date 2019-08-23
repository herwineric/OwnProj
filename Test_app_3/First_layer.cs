using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_app_3.Utils;



namespace Test_app_3
{
    public partial class First_layer : Form
    {

        private int counter = 0; //counter for amount of clicks
        private PictureBox tmp_pic = new PictureBox();


        public First_layer()
        {
            InitializeComponent();


            //Set_all_images_and_positions(); //sets all the relevant images



            pictureBox1.Click += new EventHandler(Do_Move_image);
            pictureBox2.Click += new EventHandler(Do_Move_image);
            pictureBox3.Click += new EventHandler(Do_Move_image);
            pictureBox6.Click += new EventHandler(Do_Move_image);
            pictureBox5.Click += new EventHandler(Do_Move_image);
            pictureBox4.Click += new EventHandler(Do_Move_image);
            pictureBox8.Click += new EventHandler(Do_Move_image);
            pictureBox7.Click += new EventHandler(Do_Move_image);

            pictureBox9.Click += new EventHandler(Do_Move_image);
            pictureBox10.Click += new EventHandler(Do_Move_image);
            pictureBox11.Click += new EventHandler(Do_Move_image);
            pictureBox12.Click += new EventHandler(Do_Move_image);
            pictureBox13.Click += new EventHandler(Do_Move_image);
            pictureBox14.Click += new EventHandler(Do_Move_image);
            pictureBox15.Click += new EventHandler(Do_Move_image);
            pictureBox16.Click += new EventHandler(Do_Move_image);

            button1.Click += new EventHandler(reset_button);
        }




        #region Events
        private void Do_Move_image(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender; //cast the object into a picturebox

            if (pic.Image != null && counter == 1)
            {
                MessageBox.Show("There is shit in the way");
                tmp_pic.BorderStyle = BorderStyle.FixedSingle;
                counter--;
            }
            else if (pic.Image != null && counter == 0)
            {
                this.tmp_pic = pic; // make a "copy" the PictureBox instance(class) to the "outside"
                tmp_pic.Image = pic.Image; //move the image to the new instance (temporary)
                pic.BorderStyle = BorderStyle.Fixed3D; //nice things
                counter++;

            }
            else if (pic.Image == null && counter == 1) //if there is not an image and we have already clicked
            {
                pic.Image = tmp_pic.Image; //move the temporary image to the new image
                pic.BorderStyle = BorderStyle.FixedSingle;
                Reset_fields(); //set counter and image to null
            }
        }

        
        private void reset_button(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure you want to restart?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Set_all_images_and_positions();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        #endregion


        private void Reset_fields()
        {
            counter = 0;
            tmp_pic.Image = null;
            tmp_pic.BorderStyle = BorderStyle.FixedSingle;
        }


        private void Set_all_images_and_positions()
        {
            Image img = Image.FromFile(@"Resources\test_img2.png");
            pictureBox1.Image = new Bitmap(img, 30, 30);

            Image img1 = Image.FromFile(@"Resources\moon.png");
            pictureBox2.Image = new Bitmap(img1, 30, 30);
        }




       
    }
}
