using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace KeyboardApp
{


    public partial class Form1 : Form
    {
        // Import necessary Windows API functions
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string? lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set the title of your AS400 terminal window
            string terminalWindowTitle = "Session A - [24 x 80]"; // Change to your terminal window's title
            IntPtr terminalHandle = FindWindow(null, terminalWindowTitle);

            if (terminalHandle == IntPtr.Zero)
            {
                txtOutput.Text = "Terminal window not found!";
                return;
            }

            // Bring the terminal window to the foreground
            SetForegroundWindow(terminalHandle);

            // Wait for the terminal window to become active
            while (GetForegroundWindow() != terminalHandle)
            {
                Thread.Sleep(100); // Wait 100ms before checking again
            }

            // Debug
            txtOutput.Text = "Terminal is now the active window. Starting automation...";

            // Tab 
            SendKeys.SendWait("{TAB}");
            Thread.Sleep(500); // Delay for half a second

            // Down
            SendKeys.SendWait("{DOWN}");
            Thread.Sleep(500); // Delay

            // Input
            SendKeys.SendWait("Sample Text");
            Thread.Sleep(500); // Delay

            // Enter
            //SendKeys.SendWait("{ENTER}");
        }

        private void btnRestAct_Click(object sender, EventArgs e)
        {

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            // Call REST API

        }
    }
}
