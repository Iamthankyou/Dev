﻿namespace My_IPOS
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.btnGrab = new DevComponents.DotNetBar.ButtonX();
            this.btnTakeAway = new DevComponents.DotNetBar.ButtonX();
            this.btnDangXuat = new DevComponents.DotNetBar.ButtonX();
            this.btnKhoaSo = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.buttonX4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonX3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnGrab, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTakeAway, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            resources.ApplyResources(this.buttonX4, "buttonX4");
            this.buttonX4.Name = "buttonX4";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            resources.ApplyResources(this.buttonX3, "buttonX3");
            this.buttonX3.Name = "buttonX3";
            // 
            // btnGrab
            // 
            this.btnGrab.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGrab.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            resources.ApplyResources(this.btnGrab, "btnGrab");
            this.btnGrab.Name = "btnGrab";
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTakeAway.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            resources.ApplyResources(this.btnTakeAway, "btnTakeAway");
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click_1);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnDangXuat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            resources.ApplyResources(this.btnDangXuat, "btnDangXuat");
            this.btnDangXuat.Name = "btnDangXuat";
            // 
            // btnKhoaSo
            // 
            this.btnKhoaSo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKhoaSo.BackColor = System.Drawing.Color.Transparent;
            this.btnKhoaSo.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.btnKhoaSo.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoaSo.Image")));
            this.btnKhoaSo.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnKhoaSo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            resources.ApplyResources(this.btnKhoaSo, "btnKhoaSo");
            this.btnKhoaSo.Name = "btnKhoaSo";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.btnKhoaSo);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX btnGrab;
        private DevComponents.DotNetBar.ButtonX btnTakeAway;
        private DevComponents.DotNetBar.ButtonX btnDangXuat;
        private DevComponents.DotNetBar.ButtonX btnKhoaSo;
    }
}