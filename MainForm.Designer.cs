namespace XPathDesigner {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.HomePageLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.HelpLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.StringFormat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Format = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.StringFormatResult = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomePageLink,
            this.HelpLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 144);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(332, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // HomePageLink
            // 
            this.HomePageLink.IsLink = true;
            this.HomePageLink.Name = "HomePageLink";
            this.HomePageLink.Size = new System.Drawing.Size(109, 17);
            this.HomePageLink.Text = "http://organicbit.com";
            this.HomePageLink.Click += new System.EventHandler(this.HomePageLink_Click);
            // 
            // HelpLink
            // 
            this.HelpLink.IsLink = true;
            this.HelpLink.Name = "HelpLink";
            this.HelpLink.Size = new System.Drawing.Size(338, 17);
            this.HelpLink.Spring = true;
            this.HelpLink.Text = "Format Help";
            this.HelpLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HelpLink.Click += new System.EventHandler(this.HelpLink_Click);
            // 
            // StringFormat
            // 
            this.StringFormat.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.StringFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StringFormat.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.StringFormat.Location = new System.Drawing.Point(12, 103);
            this.StringFormat.Name = "StringFormat";
            this.StringFormat.ReadOnly = true;
            this.StringFormat.Size = new System.Drawing.Size(305, 11);
            this.StringFormat.TabIndex = 8;
            this.StringFormat.TabStop = false;
            this.StringFormat.Text = "String.Format(\"\");";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type:";
            // 
            // TypeList
            // 
            this.TypeList.DisplayMember = "0";
            this.TypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeList.FormattingEnabled = true;
            this.TypeList.Items.AddRange(new object[] {
            "Int32",
            "Double",
            "Decimal",
            "DateTime",
            "Char",
            "String"});
            this.TypeList.Location = new System.Drawing.Point(63, 39);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(133, 21);
            this.TypeList.TabIndex = 3;
            this.TypeList.TextChanged += new System.EventHandler(this.Type_TextChanged);
            this.TypeList.SelectedValueChanged += new System.EventHandler(this.TypeList_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Value:";
            // 
            // Format
            // 
            this.Format.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Format.Location = new System.Drawing.Point(63, 66);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(257, 21);
            this.Format.TabIndex = 5;
            this.Format.Text = "0x{0:X8}";
            this.Format.TextChanged += new System.EventHandler(this.Format_TextChanged);
            // 
            // Value
            // 
            this.Value.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Value.Location = new System.Drawing.Point(63, 12);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(257, 21);
            this.Value.TabIndex = 1;
            this.Value.Text = "1234";
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // StringFormatResult
            // 
            this.StringFormatResult.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.StringFormatResult.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.StringFormatResult.Location = new System.Drawing.Point(12, 120);
            this.StringFormatResult.Name = "StringFormatResult";
            this.StringFormatResult.ReadOnly = true;
            this.StringFormatResult.Size = new System.Drawing.Size(308, 18);
            this.StringFormatResult.TabIndex = 7;
            this.StringFormatResult.TabStop = false;
            this.StringFormatResult.TextChanged += new System.EventHandler(this.Format_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 166);
            this.Controls.Add(this.StringFormat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StringFormatResult);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MaximumSize = new System.Drawing.Size(800, 200);
            this.MinimumSize = new System.Drawing.Size(216, 200);
            this.Name = "MainForm";
            this.Text = "Format Designer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel HomePageLink;
        private System.Windows.Forms.ToolStripStatusLabel HelpLink;
        private System.Windows.Forms.TextBox StringFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Format;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox StringFormatResult;
    }
}

