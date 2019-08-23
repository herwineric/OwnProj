using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_app_3.InheritClasses
{
    public class ChessPictureBox : PictureBox
    {

        private string _location;

        public string LocationChess
        {
            get
            {
                return _location;
            }
                

            set
            {
                _location = value;
            }
             
        }



    }
}
