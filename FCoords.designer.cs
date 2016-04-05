namespace ExtentCmd
{
    partial class FCoords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCoords = new System.Windows.Forms.TextBox();
            this.rbSimpleBounds = new System.Windows.Forms.RadioButton();
            this.rbFlexXML = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.rbJavaScript = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtCoords
            // 
            this.txtCoords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoords.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCoords.Location = new System.Drawing.Point(16, 78);
            this.txtCoords.Multiline = true;
            this.txtCoords.Name = "txtCoords";
            this.txtCoords.ReadOnly = true;
            this.txtCoords.Size = new System.Drawing.Size(258, 90);
            this.txtCoords.TabIndex = 2;
            this.txtCoords.WordWrap = false;
            // 
            // rbSimpleBounds
            // 
            this.rbSimpleBounds.AutoSize = true;
            this.rbSimpleBounds.Location = new System.Drawing.Point(16, 12);
            this.rbSimpleBounds.Name = "rbSimpleBounds";
            this.rbSimpleBounds.Size = new System.Drawing.Size(94, 17);
            this.rbSimpleBounds.TabIndex = 0;
            this.rbSimpleBounds.Tag = "{0}{4}{1}{4}{2}{4}{3}";
            this.rbSimpleBounds.Text = "&Simple bounds";
            this.rbSimpleBounds.UseVisualStyleBackColor = true;
            this.rbSimpleBounds.CheckedChanged += new System.EventHandler(this.rbFormat_CheckedChanged);
            // 
            // rbFlexXML
            // 
            this.rbFlexXML.AutoSize = true;
            this.rbFlexXML.Location = new System.Drawing.Point(16, 32);
            this.rbFlexXML.Name = "rbFlexXML";
            this.rbFlexXML.Size = new System.Drawing.Size(93, 17);
            this.rbFlexXML.TabIndex = 1;
            this.rbFlexXML.Tag = "xmin=\"{0}\" ymin=\"{1}\" xmax=\"{2}\" ymax=\"{3}\"";
            this.rbFlexXML.Text = "&Flex XML style";
            this.rbFlexXML.UseVisualStyleBackColor = true;
            this.rbFlexXML.CheckedChanged += new System.EventHandler(this.rbFormat_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(199, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(199, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 26);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // rbJavaScript
            // 
            this.rbJavaScript.AutoSize = true;
            this.rbJavaScript.Location = new System.Drawing.Point(16, 52);
            this.rbJavaScript.Name = "rbJavaScript";
            this.rbJavaScript.Size = new System.Drawing.Size(99, 17);
            this.rbJavaScript.TabIndex = 5;
            this.rbJavaScript.Tag = "xmin:{0}, ymin:{1}, xmax:{2}, ymax:{3}";
            this.rbJavaScript.Text = "&JavaScript style";
            this.rbJavaScript.UseVisualStyleBackColor = true;
            this.rbJavaScript.CheckedChanged += new System.EventHandler(this.rbFormat_CheckedChanged);
            // 
            // FCoords
            // 
            this.AcceptButton = this.btnCopy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(286, 180);
            this.Controls.Add(this.rbJavaScript);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rbFlexXML);
            this.Controls.Add(this.rbSimpleBounds);
            this.Controls.Add(this.txtCoords);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCoords";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Bounding Box Coordinates";
            this.Load += new System.EventHandler(this.FCoords_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FCoords_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCoords;
        private System.Windows.Forms.RadioButton rbSimpleBounds;
        private System.Windows.Forms.RadioButton rbFlexXML;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.RadioButton rbJavaScript;
    }
}