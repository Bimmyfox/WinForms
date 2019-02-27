using System;
using System.Threading;
using System.Windows.Forms;

namespace TestTask
{
    sealed class MyClass
    {

        private MyClass() { }
        private static MyClass source = null;
        private static readonly object threadlock = new object();

        public static MyClass Source
        {
            get
            {
                lock (threadlock)
                {
                    if (source == null)
                        source = new MyClass();

                    return source;
                }
            }
        }


        public delegate void EndOfProcess();
        public event EndOfProcess EndOfWorkMethod;

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        public void DoSomething()
        {
            Thread.Sleep(5000);
            try
            {
                EndOfWorkMethod();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}