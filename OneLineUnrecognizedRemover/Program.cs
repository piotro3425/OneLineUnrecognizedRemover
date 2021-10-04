using System.IO;
using System.Linq;

namespace OneLineUnrecognizedRemover
{
   class Program
   {
      static void Main(string[] args) => File.WriteAllLines("out\\" + args[0], File.ReadAllLines(args[0]).Where(e => !e.Contains("#unrecognized text#")).ToArray());
   }
}
