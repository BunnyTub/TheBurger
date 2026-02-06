using TheBurger.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheBurger
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult result = MessageBox.Show("What size of the burger do you want?\r\n\r\n" +
                "YES = Big\r\n" +
                "NO = Small", "The Burger", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            Bitmap bitmap = Resources.CHEESEBURGER_Small;

            switch (result)
            {
                case DialogResult.Yes:
                    bitmap = Resources.CHEESEBURGER;
                    break;
                case DialogResult.No:
                    bitmap = Resources.CHEESEBURGER_Small;
                    break;
                case DialogResult.Cancel:
                    return;
            }

            Application.Run(new TransparentImgForm(bitmap));
        }
    }
}
