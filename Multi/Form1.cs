using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi
{
    public partial class Form1 : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
            Set_Data();
        }

        #region Font/Data-Stuff
        private void Load_Data()
        {
            Load_Font(Path.Combine(Application.StartupPath, "Fonts","OpenSans-Light.ttf")); // #2 - Open Sans Light
            Load_Font(Path.Combine(Application.StartupPath, "Fonts", "OpenSans-LightItalic.ttf")); // #2.italic - Open Sans Light Italic
            Load_Font(Path.Combine(Application.StartupPath, "Fonts", "OpenSans-Italic.ttf")); //#0.italic - Open Sans Italic  
                // #0 (not in the list but available) - Open Sans Regular
            Load_Font(Path.Combine(Application.StartupPath, "Fonts", "OpenSans-ExtraBold.ttf")); // #1 - Open Sans Extra Bold
            Load_Font(Path.Combine(Application.StartupPath, "Fonts", "OpenSans-ExtraBoldItalic.ttf")); // #1.italic - Open Sans Extra Bold Italic
        }

        private void Set_Data()
        {

        }

        private void Set_Font(Control control, FontFamily font, int size, FontStyle style)
        {
            control.Font = new Font(font, size, style);
        }

        private void Load_Font(string fontFile)
        {
            pfc.AddFontFile(fontFile);
        }

        #endregion

        private void lollipopButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text == ("Password"))
            {
                textBoxPass.Text = "";
                textBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Username")
                textBoxUser.Text = "";
        }
    }
}
