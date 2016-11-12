using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSVEP_Speller_CSharp.Forms
{
    public partial class ConfigUI : Form
    {
        //Fields
        public Speller_Parms parms = new Speller_Parms();

        public ConfigUI()
        {
            InitializeComponent();
        }
    }
}
