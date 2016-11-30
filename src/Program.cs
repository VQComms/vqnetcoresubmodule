using System;
using VQ.ViewModels.AcanoAccessMethod;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var model = new AcanoAccessMethodViewModel();
            Console.WriteLine(model.Id);

        }
    }
}
