using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace test
{
    partial class Form2
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new Gizmox.WebGUI.Forms.Button();
            this.checkBox1 = new Gizmox.WebGUI.Forms.CheckBox();
            this.button2 = new Gizmox.WebGUI.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ExcludeFromUniqueId = false;
            this.button1.Location = new System.Drawing.Point(86, 101);
            this.button1.Name = "button1";
            this.button1.PerformLayoutEnabled = true;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ExcludeFromUniqueId = false;
            this.checkBox1.Location = new System.Drawing.Point(86, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.PerformLayoutEnabled = true;
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            // 
            // button2
            // 
            this.button2.ExcludeFromUniqueId = false;
            this.button2.Location = new System.Drawing.Point(195, 101);
            this.button2.Name = "button2";
            this.button2.PerformLayoutEnabled = true;
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Size = new System.Drawing.Size(419, 466);
            this.Text = "Form2";
            this.ResumeLayout(false);

        }


        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
    }
}