using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Xml;

namespace XPathDesigner {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            TypeList.SelectedIndex = 0;
            UpdateResults();
        }

        private void Value_TextChanged(object sender, EventArgs e) {
            UpdateResults();
        }

        private void Type_TextChanged(object sender, EventArgs e) {
            UpdateResults();
        }

        private void Format_TextChanged(object sender, EventArgs e) {
            UpdateResults();
        }

        private void TypeList_SelectedValueChanged(object sender, EventArgs e) {
            UpdateResults();
        }

        private void UpdateResults() {
            try {
                object value;
                switch (TypeList.Text) {
                case "Int32":
                    value = Convert.ToInt32(Value.Text);
                    break;
                case "Double":
                    value = Convert.ToDouble(Value.Text);
                    break;
                case "Decimal":
                    value = Convert.ToDecimal(Value.Text);
                    break;
                case "DateTime":
                    value = Convert.ToDateTime(Value.Text);
                    break;
                case "Char":
                    value = Convert.ToChar(Value.Text);
                    break;
                case "String":
                    value = Convert.ToString(Value.Text);
                    break;

                default:
                    string msg = String.Format("Unknown type '{0}'.", TypeList.Text);
                    throw new Exception(msg);
                }

                StringFormat.Text = String.Format("String.Format(\"{0}\", value);", Format.Text);
                StringFormatResult.Text = String.Format(Format.Text, value);
                StringFormatResult.Visible = true;

            } catch (Exception e) {
                StringFormat.Text = e.Message;
                StringFormatResult.Visible = false;
            }
        }

        private void HomePageLink_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://organicbit.com");
        }

        private void HelpLink_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://google.com/search?q=c%23+string+format+specifiers");
        }

    }
}