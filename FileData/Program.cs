using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
  

        public static void Main(string[] args)
        {
            IFileInformation fileInformation= new FileInformation();
            if (args.Length == 2)
            {
                fileInformation.FirstRequirement(args[0], args[1]);
                fileInformation.SecondRequirement(args[0], args[1]);
            }

            Console.Read();
        }

       
    }
}
