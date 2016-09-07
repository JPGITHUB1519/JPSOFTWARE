using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class jptextbox : TextBox
    {
        public jptextbox()
        {
            InitializeComponent();
        }

        // propiedad para validar
        public Boolean validar
        {
            set;
            get;
        }

        public jptextbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
