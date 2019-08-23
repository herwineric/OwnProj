using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_app_3.Utils
{
    public class Move_Image
    {


        private int counter = 0; //counter for amount of clicks
        private PictureBox tmp_pic = new PictureBox();


        public Move_Image()
        {
            counter = 0; 
            tmp_pic = null;
        }


        public void Do_Move_image(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender; //cast the object into a picturebox

            if (pic.Image != null && counter == 1)
            {
                MessageBox.Show("There is shit in the way");
            }
            else if (pic.Image != null && counter == 0)
            {

                tmp_pic.Image = pic.Image; //move the image
                pic.BorderStyle = BorderStyle.Fixed3D; //nice things
                counter++;

            }
            else if (pic.Image == null && counter == 1)
            {
                pic.Image = tmp_pic.Image;
                counter = 0;


                //Move_Image();

            }




        }
    }
}
