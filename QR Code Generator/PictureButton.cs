using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Generator
{
    public partial class PictureButton : UserControl
    {
        private String _text = "Button";
        private Image _image = null;

        public String Text_
        {
            get
            {
                return _text;
            }
            set
            {
                this._text = value;
                Text.Text = _text;
                this.Invalidate();
            }
        }

        public Image Image_
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                picture.Image = _image;
                this.Invalidate();
            }
        }

        public PictureButton()
        {
            InitializeComponent();

            Text.Text = _text;
            picture.Image = _image;
       

        }

        private void Text_Enter(object sender, EventArgs e)
        {

        }
    }
}
