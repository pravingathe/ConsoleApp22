using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
   public interface IFileInformation
    {
        string ErrorMessage { get; set; }
        void FirstRequirement(string fileParam, string filePath);
        void SecondRequirement(string fileParam, string filePath);
    }
}
