using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperacion.CapaServiciosWeb
{
    public partial class ServiciosWeb : Component
    {
        public ServiciosWeb()
        {
            InitializeComponent();
        }

        public ServiciosWeb(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
