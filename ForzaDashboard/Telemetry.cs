using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ForzaDashboard
{
    public class Telemetry : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Rpm { get; set; }
    }
}
