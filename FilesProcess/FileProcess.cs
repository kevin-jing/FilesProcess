using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FilesProcessApp
{
    class FileProcess
    {
        static public int ChangeNumber(string path, int inc, string left, string right)
        {
            DirectoryInfo folder = new DirectoryInfo(path); ;
            int n = 0;
            foreach (FileInfo file in folder.GetFiles())
            {
                string fn = file.Name;
                if (fn.StartsWith(left) && fn.EndsWith(right, StringComparison.CurrentCultureIgnoreCase))
                {
                    int nubLength = fn.Length - left.Length - right.Length;
                    int num = int.Parse(fn.Substring(left.Length, nubLength));
                    num += inc;
                    if (num < 0)
                        continue;

                    fn = Path.Combine(file.DirectoryName, left + num.ToString("000") + right);
                    // the num length is fixed to 4, I don't know how to ...
                    file.MoveTo(fn);
                    ++n;
                }
            }

            return n;
        }

        static public int ExtractFiles(
            string srcPath,  // source path
            string dstPath, // destination path
            int    spacing)
        {
            DirectoryInfo srcFolder = new DirectoryInfo(srcPath);
            DirectoryInfo dstFolder = new DirectoryInfo(dstPath);
            if (!dstFolder.Exists)
                dstFolder.Create();

            int i = 0, j = 0;
            foreach (FileInfo file in srcFolder.GetFiles())
            {
                // if you want to extract by file name instead of file order, use the following line
                // int n = int.Parse(file.Name.Substring(preOffset, file.Name.Length - preOffset - postOffset));
                if (i % spacing != 0)
                {
                    ++i;
                    continue;
                }

                string dstFullName = Path.Combine(dstPath, file.Name);
                file.MoveTo(dstFullName);
                ++i; ++j;
            }
            return j;
        }
    }
}
