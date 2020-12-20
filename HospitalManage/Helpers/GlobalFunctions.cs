using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HospitalManage.Helpers
{
    class GlobalFunctions
    {
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void OpenForm(Form oldOne, Form newOne)
        {
            oldOne.Hide();
            newOne.Show();
        }
    }
}
