// Copyright © 2019 by Htoon Aung Kyaw, Star Light Group, Taungtha.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zawgyi_to_Unicode_Converter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //=================================================================================
            //=================================================================================
            PrivateFontCollection pfcFontCollection = new PrivateFontCollection();

            if (AppUtil.CheckFontInstalled("Zawgyi-One") == true)
                txtInput.Font = new Font("Zawgyi-One", 16, FontStyle.Regular);
            else
            {
                pfcFontCollection.AddFontFile(AppUtil.AppPath() + "Fonts\\ZawgyiOne2008.ttf");
                //pfcFontCollection.AddFontFile(Properties.Resources.WinInnwa);

                txtInput.Font = new Font(pfcFontCollection.Families.First(), 16, FontStyle.Regular);
            }

            if (AppUtil.CheckFontInstalled("Pyidaungsu") == true)
                txtOutput.Font = new Font("Pyidaungsu", 10, FontStyle.Regular);
            else
            {
                pfcFontCollection.AddFontFile(AppUtil.AppPath() + "Fonts\\Pyidaungsu-1.8_Regular.ttf");
                //pfcFontCollection.AddFontFile(Properties.Resources.ZawgyiOne2008);

                txtOutput.Font = new Font("Pyidaungsu", 10, FontStyle.Regular);
            }
            //=================================================================================
            int intCnt = 0;

            for (intCnt = 8; intCnt <= 24; intCnt += 2)
            {
                cboInputSize.Items.Add(intCnt.ToString());
                cboOutputSize.Items.Add(intCnt.ToString());
            }

            cboInputSize.SelectedIndex = 2;
            cboOutputSize.SelectedIndex = 2;

            cboInput.Items.Add("Zawgyi-One");

            cboInput.SelectedIndex = 0;

            cboOutput.Items.Add("Pyidaungsu");

            cboOutput.SelectedIndex = 0;
            //=================================================================================
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            //=================================================================================
            //=================================================================================
            txtInput.Text = string.Empty;
            txtOutput.Text = string.Empty;
            //=================================================================================
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            //=================================================================================
            //=================================================================================
            txtOutput.Text = Zawgyi2Unicode.Convert(txtInput.Text);
            //=================================================================================
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            //=================================================================================
            //=================================================================================
            Clipboard.SetText(txtOutput.Text, TextDataFormat.UnicodeText);
            //=================================================================================
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            //=================================================================================
            //=================================================================================
            Application.Exit();
            //=================================================================================
        }

        private void cboInputSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //=================================================================================
            //=================================================================================
            try
            {
                txtInput.Font = new Font(cboInput.SelectedItem.ToString(), Convert.ToSingle(cboInputSize.SelectedItem), FontStyle.Regular);
                txtOutput.Font = new Font(cboOutput.SelectedItem.ToString(), Convert.ToSingle(cboOutputSize.SelectedItem), FontStyle.Regular);
            }
            catch
            {
                //throw (ex);
            }
            //=================================================================================
        }

        private void cboOutputSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //=================================================================================
            //=================================================================================
            try
            {
                txtOutput.Font = new Font(cboOutput.SelectedItem.ToString(), Convert.ToSingle(cboOutputSize.SelectedItem), FontStyle.Regular);
            }
            catch
            {
                //throw (ex);
            }
            //=================================================================================
        }
    }
}
