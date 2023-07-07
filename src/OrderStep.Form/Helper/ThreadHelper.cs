using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderStep.Api.Helper
{
    public static class ThreadHelper
    {
        public static void OpenNewForm<T>(T className, object[] arg) where T : Form
        {
            
            var thread = new Thread(OpenThread);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        private static void OpenThread(object obj)
        {
            Application.Run(new Order());
        }
    }
}
