﻿namespace U3_Loader
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.Box7A = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.CSV7A = new System.Windows.Forms.Button();
            this.TextBox7A = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CSV00 = new System.Windows.Forms.Button();
            this.TextBox00 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TextBoxSamp = new System.Windows.Forms.RichTextBox();
            this.SampleCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Box7A.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Box7A);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load U3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Box7A
            // 
            this.Box7A.Controls.Add(this.tabPage2);
            this.Box7A.Controls.Add(this.tabPage1);
            this.Box7A.Controls.Add(this.tabPage3);
            this.Box7A.Location = new System.Drawing.Point(4, 4);
            this.Box7A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Box7A.Name = "Box7A";
            this.Box7A.SelectedIndex = 0;
            this.Box7A.Size = new System.Drawing.Size(1063, 491);
            this.Box7A.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1055, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "First Command 7A";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(4, 4);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.CSV7A);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.AutoScroll = true;
            this.splitContainer3.Panel2.Controls.Add(this.TextBox7A);
            this.splitContainer3.Size = new System.Drawing.Size(1047, 454);
            this.splitContainer3.SplitterDistance = 51;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // CSV7A
            // 
            this.CSV7A.Location = new System.Drawing.Point(4, 0);
            this.CSV7A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CSV7A.Name = "CSV7A";
            this.CSV7A.Size = new System.Drawing.Size(121, 48);
            this.CSV7A.TabIndex = 0;
            this.CSV7A.Text = "Export CSV";
            this.CSV7A.UseVisualStyleBackColor = true;
            this.CSV7A.Click += new System.EventHandler(this.CSV7A_Click);
            // 
            // TextBox7A
            // 
            this.TextBox7A.AcceptsTab = true;
            this.TextBox7A.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox7A.Location = new System.Drawing.Point(4, 4);
            this.TextBox7A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox7A.Name = "TextBox7A";
            this.TextBox7A.Size = new System.Drawing.Size(1032, 387);
            this.TextBox7A.TabIndex = 0;
            this.TextBox7A.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1055, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "First Command 00";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 4);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.CSV00);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.TextBox00);
            this.splitContainer2.Size = new System.Drawing.Size(1047, 454);
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // CSV00
            // 
            this.CSV00.Location = new System.Drawing.Point(4, 0);
            this.CSV00.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CSV00.Name = "CSV00";
            this.CSV00.Size = new System.Drawing.Size(121, 48);
            this.CSV00.TabIndex = 1;
            this.CSV00.Text = "Export CSV";
            this.CSV00.UseVisualStyleBackColor = true;
            this.CSV00.Click += new System.EventHandler(this.CSV00_Click);
            // 
            // TextBox00
            // 
            this.TextBox00.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox00.Location = new System.Drawing.Point(4, 4);
            this.TextBox00.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox00.Name = "TextBox00";
            this.TextBox00.Size = new System.Drawing.Size(1039, 388);
            this.TextBox00.TabIndex = 0;
            this.TextBox00.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SampleCSV);
            this.tabPage3.Controls.Add(this.TextBoxSamp);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1055, 462);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sample table";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TextBoxSamp
            // 
            this.TextBoxSamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSamp.Location = new System.Drawing.Point(8, 60);
            this.TextBoxSamp.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSamp.Name = "TextBoxSamp";
            this.TextBoxSamp.Size = new System.Drawing.Size(1039, 365);
            this.TextBoxSamp.TabIndex = 1;
            this.TextBoxSamp.Text = "";
            // 
            // SampleCSV
            // 
            this.SampleCSV.Location = new System.Drawing.Point(0, 4);
            this.SampleCSV.Margin = new System.Windows.Forms.Padding(4);
            this.SampleCSV.Name = "SampleCSV";
            this.SampleCSV.Size = new System.Drawing.Size(121, 48);
            this.SampleCSV.TabIndex = 2;
            this.SampleCSV.Text = "Export CSV";
            this.SampleCSV.UseVisualStyleBackColor = true;
            this.SampleCSV.Click += new System.EventHandler(this.SampleCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "U3 Loader";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Box7A.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl Box7A;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button CSV00;
        private System.Windows.Forms.RichTextBox TextBox00;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button CSV7A;
        private System.Windows.Forms.RichTextBox TextBox7A;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox TextBoxSamp;
        private System.Windows.Forms.Button SampleCSV;
    }
}

