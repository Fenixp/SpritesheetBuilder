using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIBackend.Resources;

namespace GUIBackend.Controllers
{
    public class ControllerBase
    {
        protected void ShowError(string message)
        {
            MessageBox.Show(message, DialogRX.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void ShowWarning(string message)
        {
            MessageBox.Show(message, DialogRX.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected bool ShowPrompt(string message)
        {
            DialogResult result = MessageBox.Show(message, DialogRX.Prompt, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
