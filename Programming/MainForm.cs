using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        private TabControl tabControl1;
        private TextBox IntValueBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label IntValue;
        private Label ChooseValue;
        private Label ChooseEnumination;
        private TabPage tabPage1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IntValue = new System.Windows.Forms.Label();
            this.ChooseValue = new System.Windows.Forms.Label();
            this.ChooseEnumination = new System.Windows.Forms.Label();
            this.IntValueBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.IntValue);
            this.tabPage1.Controls.Add(this.ChooseValue);
            this.tabPage1.Controls.Add(this.ChooseEnumination);
            this.tabPage1.Controls.Add(this.IntValueBox);
            this.tabPage1.Controls.Add(this.ValuesListBox);
            this.tabPage1.Controls.Add(this.EnumsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // IntValue
            // 
            this.IntValue.AutoSize = true;
            this.IntValue.Location = new System.Drawing.Point(543, 39);
            this.IntValue.Name = "IntValue";
            this.IntValue.Size = new System.Drawing.Size(59, 16);
            this.IntValue.TabIndex = 5;
            this.IntValue.Text = "Int value:";
            // 
            // ChooseValue
            // 
            this.ChooseValue.AutoSize = true;
            this.ChooseValue.Location = new System.Drawing.Point(298, 39);
            this.ChooseValue.Name = "ChooseValue";
            this.ChooseValue.Size = new System.Drawing.Size(93, 16);
            this.ChooseValue.TabIndex = 4;
            this.ChooseValue.Text = "Choose value:";
            this.ChooseValue.Click += new System.EventHandler(this.label2_Click);
            // 
            // ChooseEnumination
            // 
            this.ChooseEnumination.AutoSize = true;
            this.ChooseEnumination.Location = new System.Drawing.Point(41, 39);
            this.ChooseEnumination.Name = "ChooseEnumination";
            this.ChooseEnumination.Size = new System.Drawing.Size(134, 16);
            this.ChooseEnumination.TabIndex = 3;
            this.ChooseEnumination.Text = "Choose enumaration:";
            // 
            // IntValueBox
            // 
            this.IntValueBox.Location = new System.Drawing.Point(546, 61);
            this.IntValueBox.Name = "IntValueBox";
            this.IntValueBox.Size = new System.Drawing.Size(174, 22);
            this.IntValueBox.TabIndex = 2;
            this.IntValueBox.Text = "1";
            this.IntValueBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(301, 61);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(213, 308);
            this.ValuesListBox.TabIndex = 1;
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(41, 61);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(228, 308);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(768, 490);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
