using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.Model;

namespace WpfApp1.Service
{
    public static class MyService
    {
        public static Frame MyServiceNavigateApp { get; set; }

        public static MasterPoldb2Entities DB { get; set; }
    } 
}
