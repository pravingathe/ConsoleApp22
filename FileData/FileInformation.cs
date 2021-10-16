using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
  public class FileInformation :IFileInformation
    {
          List<string> versionSamples;
          List<string> sizeSamples;
          FileDetails fileDetails;
          public string ErrorMessage = null;

        string IFileInformation.ErrorMessage
        {
            get
            {
                return ErrorMessage;
            }

            set
            {
                ErrorMessage = value;
            }
        }

        public FileInformation()
        {
            fileDetails = new FileDetails();
        }
        private void SetSampleData()
        {
            versionSamples = new List<string>();
            versionSamples.Add("-v");
            versionSamples.Add("--v");
            versionSamples.Add("/v");
            versionSamples.Add("--version");

            sizeSamples = new List<string>();
            sizeSamples.Add("-s");
            sizeSamples.Add("--s");
            sizeSamples.Add("/s");
            sizeSamples.Add("--size");
        }
        
        void IFileInformation.FirstRequirement(string fileParam, string filePath)
        {
            Console.WriteLine("FirstRequirement...");

            if (fileParam == "-v")
                Console.WriteLine(fileDetails.Version(filePath));
            else
            {
                ErrorMessage = "FirstRequirement Failed! Only -v is allowed.";
                Console.WriteLine(ErrorMessage);
            }
        }

        void IFileInformation.SecondRequirement(string fileParam, string filePath)
        {
            Console.WriteLine("SecondRequirement...");

            SetSampleData();

            if (versionSamples.Contains(fileParam))
                Console.WriteLine(fileDetails.Version(fileParam));
            else if (sizeSamples.Contains(fileParam))
                Console.WriteLine(fileDetails.Size(fileParam));
            else
            {
                ErrorMessage = "SecondRequirement Failed! Size or version param doesn't match.";
                Console.WriteLine(ErrorMessage);
            }
        }
    }
}
