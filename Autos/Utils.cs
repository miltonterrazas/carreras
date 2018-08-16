using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Carreras
{
    public static class Utils
    {
        [DllImport("GDI32.dll")]
        public static extern void SwapBuffers(uint hdc); 
    }
}
