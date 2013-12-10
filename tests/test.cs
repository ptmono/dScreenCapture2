using System;
using System.IO;
using System.Windows.Forms;
using Libs;

namespace CropTest
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
	    ImageContainer ic = new ImageContainer();
	    ic.getPath();
        }
    }
}
