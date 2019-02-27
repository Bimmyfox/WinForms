using System;
using System.Windows.Forms;

namespace TestTask
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            MyClass.Source.EndOfWorkMethod += ShowEndMessage;
            MyClass.Source.EndOfWorkMethod += UnlockButton;
        }

        private void beginProcessing_Click(object sender, EventArgs e)
        {
            beginProcessing.Enabled = false;
            ProgressBarWindow progressBar = new ProgressBarWindow();
            progressBar.Show();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyClass.Source.EndOfWorkMethod -= ShowEndMessage;
            MyClass.Source.EndOfWorkMethod -= UnlockButton;
        }

        private void ShowEndMessage()
        {
            try
            {
                Action action = () => messageLabel.Text = "Process Completed";

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


        private void UnlockButton()
        {
            try
            {
                Action action = () => beginProcessing.Enabled = true;

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
    }
}
