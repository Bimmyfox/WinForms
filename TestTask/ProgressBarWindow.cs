using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace TestTask
{
    public partial class ProgressBarWindow : Form
    {
        Timer time = new Timer();


        public ProgressBarWindow()
        {
            InitializeComponent();
            InitializeMyTimer();
            RunDoSometingMethodInNewThread();
        }

        private void CloseForm()
        {
            try
            {
                Action action = () => Close();
                if (InvokeRequired)
                    Invoke(action);
                else
                    action();
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void InitializeMyTimer()
        {
            time.Interval = 1000;
            time.Tick += new EventHandler(IncreaseProgressBar);
            progressBar1.Maximum = 5;
            time.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            progressBar1.Increment(1);

            if (progressBar1.Value == progressBar1.Maximum)
                time.Stop();
        }

        private void ProgressBarWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyClass.Source.EndOfWorkMethod -= CloseForm;
        }

        private void ProgressBarWindow_Load(object sender, EventArgs e)
        {
            MyClass.Source.EndOfWorkMethod += CloseForm;
        }

        private void RunDoSometingMethodInNewThread()
        {
            Thread myThread = new Thread(MyClass.Source.DoSomething);
            myThread.Start();
        }
    }
}