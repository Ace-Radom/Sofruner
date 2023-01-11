﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Sofruner_ng
{
    public partial class MainWidget : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public MainWidget()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
                                                                           MaterialSkin.Primary.Indigo700,
                                                                           MaterialSkin.Primary.Indigo100,
                                                                           MaterialSkin.Accent.Pink200,
                                                                           MaterialSkin.TextShade.WHITE);
        }
    }
}
