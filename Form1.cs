using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            // Seperate change keyboard layout to another function is work but when include in this line it's not work!!

            // Get screen data by copy-paste
            SendKeys.SendWait("%{e}");
            Thread.Sleep(100);

            SendKeys.SendWait("c");
            Thread.Sleep(100);

            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string clipboardText = Clipboard.GetText(TextDataFormat.Text);
                txtOutput.Text = clipboardText;
            }

            // Fill-in data
            // Tab 
            //SendKeys.SendWait("{TAB}");
            //Thread.Sleep(500); // Delay for half a second

            // Down
            //SendKeys.SendWait("{DOWN}");
            //Thread.Sleep(500); // Delay

            // Input Support only Eng
            //SendKeys.SendWait("Sample Text");
            //Thread.Sleep(100); // Delay

            // Paste text -> cannot paste Thai character to the terminal
            //Clipboard.SetText("���ʴ�");
            //SendKeys.SendWait("%{e}");
            //Thread.Sleep(100);

            //SendKeys.SendWait("p");
            //Thread.Sleep(100);

            // Enter
            //SendKeys.SendWait("{ENTER}");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            InputLanguage myDefaultLanguage = InputLanguage.DefaultInputLanguage;
            InputLanguage myCurrentLanguage = InputLanguage.CurrentInputLanguage;
            txtOutput.Text = "Current input language is: " + myCurrentLanguage.Culture.EnglishName + '\n';
            txtOutput.Text += "Default input language is: " + myDefaultLanguage.Culture.EnglishName + '\n';

            // Changes the current input language to the default, and prints the new current language.
            InputLanguage.CurrentInputLanguage = myDefaultLanguage;
            txtOutput.Text += "Current input language is now: " + myDefaultLanguage.Culture.EnglishName;
        }
    }
}
