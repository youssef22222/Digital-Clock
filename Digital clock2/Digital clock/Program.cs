using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Digital_clock
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    //make sure that number has 2 digits
    static public class appendZero0
    {
         static public string append(int number)
        {

            string first, last;
            if (number == 1)
                return "0 " + number.ToString();
            if (number <= 9)
                return "0" + number.ToString();
            last = (number % 10).ToString();
            number /= 10;
            first = (number % 10).ToString();
            if (first == "1")
                first = " 1";
            if (last == "1")
                last = " 1";
            return first + last;
        }
    }


}
