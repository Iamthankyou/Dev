namespace My_IPOS
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
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.lbDangXuat = new System.Windows.Forms.Label();
            this.lbKhoaSo = new System.Windows.Forms.Label();
            this.lbSoDoChinh = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnTakeAway);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnTakeAway
            // 
            resources.ApplyResources(this.btnTakeAway, "btnTakeAway");
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.UseVisualStyleBackColor = true;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // lbDangXuat
            // 
            resources.ApplyResources(this.lbDangXuat, "lbDangXuat");
            this.lbDangXuat.Name = "lbDangXuat";
            // 
            // lbKhoaSo
            // 
            resources.ApplyResources(this.lbKhoaSo, "lbKhoaSo");
            this.lbKhoaSo.Name = "lbKhoaSo";
            // 
            // lbSoDoChinh
            // 
            resources.ApplyResources(this.lbSoDoChinh, "lbSoDoChinh");
            this.lbSoDoChinh.Name = "lbSoDoChinh";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.lbSoDoChinh);
            this.Controls.Add(this.lbKhoaSo);
            this.Controls.Add(this.lbDangXuat);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Label lbDangXuat;
        private System.Windows.Forms.Label lbKhoaSo;
        private System.Windows.Forms.Label lbSoDoChinh;
    }
}