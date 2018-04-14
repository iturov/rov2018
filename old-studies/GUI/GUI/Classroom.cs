using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    class Classroom
    {
        public static void OpenForms()
        {
            IPCam1 IPCam1_Form = new IPCam1();
            IPCam2 IPCam2_Form = new IPCam2();
            IPCam1_Form.Show();
            IPCam2_Form.Show();
        }
    }
}
