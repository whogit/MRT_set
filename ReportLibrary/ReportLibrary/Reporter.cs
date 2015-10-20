using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportLibrary
{
    public class Reporter
    {
        public static void ReportOSVersion()
        {
            string os_string = Environment.OSVersion.Version.ToString();
            if (os_string.Contains("5.1.2600") == true)
            {
                Console.WriteLine("WinXP");
            }
            else if (os_string.Contains("6.1.7600") == true)           
            {    
                 Console.WriteLine("Win7");
            }
            else
            {
                Console.WriteLine("Fall Through:");
                Console.WriteLine(os_string);
            }                        
        }
        public static bool Is64() { return IntPtr.Size == 8 ? true : false; }  

        public static void ReportOSBitVersion()
        {                        
            if (Is64())
            {
                Console.WriteLine("x64");
            }
            else
            {                
                Console.WriteLine("x86");
            }                         
        }        
    }
}
