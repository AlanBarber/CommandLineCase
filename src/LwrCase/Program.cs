using System.IO;
using System.Linq;

namespace LwrCase
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Count() != 1)
                return;

            if (!File.Exists(args[0]))
            {
                return;
            }

            File.Move(args[0], args[0].ToLower());
        }
    }
}
