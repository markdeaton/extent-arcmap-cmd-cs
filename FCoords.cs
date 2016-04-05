using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExtentCmd {
    public partial class FCoords : Form {
        private Double _xMin, _yMin, _xMax, _yMax;

        public FCoords(Double xMin, Double yMin, Double xMax, Double yMax) {
            InitializeComponent();
            _xMin = xMin; _yMin = yMin; _xMax = xMax; _yMax = yMax;
        }

        private void FCoords_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void showCoords(String sFormat) {
            txtCoords.Text = String.Format(sFormat, _xMin, _yMin, _xMax, _yMax, Environment.NewLine);
            txtCoords.SelectAll();
        }

        private void rbFormat_CheckedChanged(object sender, EventArgs e) {
            String sFormat = (sender as RadioButton).Tag.ToString();
            showCoords(sFormat);
        }

        private void FCoords_Load(object sender, EventArgs e)
        {
            rbSimpleBounds.Checked = true;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCoords.Text);
        }

    }
}
