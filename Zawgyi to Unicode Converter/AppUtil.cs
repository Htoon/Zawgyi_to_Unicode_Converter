// Copyright © 2013 by Htoon Aung Kyaw, Star Light Group, Taungtha.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zawgyi_to_Unicode_Converter
{
    class AppUtil
    {
        [System.Runtime.InteropServices.DllImport("kernel32", EntryPoint = "GetShortPathNameA", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        public static extern int GetShortPathName(string lpszLongPath, string lpszShortPath, int cchBuffer);

        public static string AppPath()
        {
            //=================================================================================
            // Retrieve the path of current application
            //=================================================================================
            return AddPathSeparator(Application.StartupPath);
            //=================================================================================
        }

        public static string AddPathSeparator(string strPath)
        {
            //=================================================================================
            // Check for path-separator character at the end of strPath
            // if not, add path-separator character (\ - back slash)
            //=================================================================================
            if (strPath.EndsWith(Convert.ToString(Path.DirectorySeparatorChar)))
                return strPath;
            else
                return strPath + Path.DirectorySeparatorChar;
            //=================================================================================
        }

        public static bool CheckFontInstalled(string strFontName)
        {
            //=================================================================================
            // 
            //=================================================================================
            InstalledFontCollection ifcFonts = new InstalledFontCollection();
            int intCnt = 0;
            bool bFlag = false;

            for (intCnt = 0; intCnt < ifcFonts.Families.Length; intCnt++)
            {
                if (ifcFonts.Families[intCnt].Name == strFontName)
                {
                    bFlag = true;
                    break;
                }
            }

            return bFlag;
            //=================================================================================
        }
    }
}
