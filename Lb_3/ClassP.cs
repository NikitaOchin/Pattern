using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Lb_3
{
    public interface FileEx
    {

    }

    public class txt : FileEx 
    {
        public txt(string n)
        {
            FileName = n;
        }
        public string FileName { get; set; }
    }

    public class rtf : FileEx
    {
        public rtf(string n)
        {
            FileName = n;
        }

        public string FileName { get; set; }
    }

    public interface Create
    {
        FileEx CreateFile(string FileName);
    }

    public class txt_cr : Create
    {
        public FileEx CreateFile(string FileName)
        {
            txt f = new txt(FileName + ".txt");
            StreamWriter sw = new StreamWriter(f.FileName);
            sw.Close();
            return f;
        }

    }

    public class rtf_cr : Create
    {
        public FileEx CreateFile(string FileName)
        {
            RichTextBox rtb = new RichTextBox();
            rtf f = new rtf(FileName + ".rtf");
            rtb.SaveFile(f.FileName, RichTextBoxStreamType.RichText);
            return f;
        }

    }

}
