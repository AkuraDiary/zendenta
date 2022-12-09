
namespace zendenta
{
    partial class FormDummy
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
            this.listPasienLayout1 = new zendenta.SubPages.DaftarPasien.ListPasienLayout();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPasienLayout1
            // 
            this.listPasienLayout1.BackColor = System.Drawing.Color.Transparent;
            this.listPasienLayout1.Location = new System.Drawing.Point(3, 3);
            this.listPasienLayout1.Name = "listPasienLayout1";
            this.listPasienLayout1.Size = new System.Drawing.Size(614, 97);
            this.listPasienLayout1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listPasienLayout1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(621, 113);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FormDummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormDummy";
            this.Text = "FormDummy";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SubPages.DaftarPasien.ListPasienLayout listPasienLayout1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}