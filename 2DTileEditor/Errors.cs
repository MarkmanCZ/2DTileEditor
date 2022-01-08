using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DTileEditor
{
    class Errors
    {
        private MessageBoxButtons box;
        private DialogResult result;
        private string caption = "Error";
        private bool shouldClose = false;

        public Errors()
        {
            box = MessageBoxButtons.OKCancel;
        }

        public void genrateBox(string message, Form form)
        {
            result = MessageBox.Show(message, caption, box, MessageBoxIcon.Error);
            if(result ==  System.Windows.Forms.DialogResult.OK)
            {
                shouldClose = true;
            }
        }

        public bool getShouldClose()
        {
            return shouldClose;
        }
    }
}
