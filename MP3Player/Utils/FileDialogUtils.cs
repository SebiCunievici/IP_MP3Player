using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3Player.Utils
{
    public static class FileDialogUtils
    {
        public static string OpenFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3 Files (*.mp3)|*.mp3";

            if (dialog.ShowDialog() == DialogResult.OK)
                return dialog.FileName;

            return null;
        }
    }
}
