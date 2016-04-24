using System.Windows.Forms;
using System.Threading.Tasks;
using System;

namespace w1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(new Action(ShowDialog));
            task.Start();
           
            Console.WriteLine("Dialog 1");
            task.Wait();
        }

        private static void ShowDialog()
        {
            MessageBox.Show("Dialog");
        }
    }
}
