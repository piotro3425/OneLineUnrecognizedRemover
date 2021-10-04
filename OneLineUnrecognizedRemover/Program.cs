using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OneLineUnrecognizedRemover
{
   class Program
   {
      static async Task Main(string[] args) => await ((args.Length > 0 && File.Exists(args[0]) && Directory.Exists("out")) ? Task.Factory.StartNew(() => File.WriteAllLines("out\\" + args[0], File.ReadAllLines(args[0]).Where(e => !e.Contains("#unrecognized text#")).ToArray())).ConfigureAwait(true) : Task.Factory.StartNew(() => Console.WriteLine("Incorrect parameters")).ConfigureAwait(true));
   }
}
