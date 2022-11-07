using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDiskInformation
{
    public class GetDiskInform
    {
        public string GetDiskInf()
        {
            string inf = String.Empty;
            DriveInfo[] info = DriveInfo.GetDrives();
            foreach(DriveInfo x_info in info)
            {
                inf = x_info.Name + Environment.NewLine + x_info.VolumeLabel + Environment.NewLine + x_info.DriveFormat;
            }
            return inf; //Getting Disk Information :D
        }
    }
}
