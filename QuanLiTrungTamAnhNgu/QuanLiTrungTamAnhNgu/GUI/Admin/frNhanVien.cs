﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLiTrungTamAnhNgu.GUI.Admin
{
    public partial class frNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frNhanVien()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            nhanVienTableAdapter1.Fill(englishCenterDataSet1.NhanVien);
        }

    }
}