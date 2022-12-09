
namespace zendenta.SubPages.Overview
{
    partial class OverviewChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.Charts.WinForms.ChartFont chartFont17 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont18 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont19 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont20 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid7 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick7 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont21 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid8 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick8 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont22 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid9 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel3 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont23 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick9 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont24 = new Guna.Charts.WinForms.ChartFont();
            this.gunaChart1 = new Guna.Charts.WinForms.GunaChart();
            this.lblGoodMorning = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLoggedInDoctor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPasienName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnMonthly = new Guna.UI2.WinForms.Guna2Button();
            this.btnWeekly = new Guna.UI2.WinForms.Guna2Button();
            this.filterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDaily = new Guna.UI2.WinForms.Guna2Button();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaChart1
            // 
            this.gunaChart1.BackColor = System.Drawing.Color.MidnightBlue;
            chartFont17.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont17;
            this.gunaChart1.Location = new System.Drawing.Point(3, 109);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(527, 218);
            this.gunaChart1.TabIndex = 0;
            chartFont18.FontName = "Arial";
            chartFont18.Size = 12;
            chartFont18.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Title.Font = chartFont18;
            chartFont19.FontName = "Arial";
            this.gunaChart1.Tooltips.BodyFont = chartFont19;
            chartFont20.FontName = "Arial";
            chartFont20.Size = 9;
            chartFont20.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Tooltips.TitleFont = chartFont20;
            this.gunaChart1.XAxes.GridLines = grid7;
            chartFont21.FontName = "Arial";
            tick7.Font = chartFont21;
            this.gunaChart1.XAxes.Ticks = tick7;
            this.gunaChart1.YAxes.GridLines = grid8;
            chartFont22.FontName = "Arial";
            tick8.Font = chartFont22;
            this.gunaChart1.YAxes.Ticks = tick8;
            this.gunaChart1.ZAxes.GridLines = grid9;
            chartFont23.FontName = "Arial";
            pointLabel3.Font = chartFont23;
            this.gunaChart1.ZAxes.PointLabels = pointLabel3;
            chartFont24.FontName = "Arial";
            tick9.Font = chartFont24;
            this.gunaChart1.ZAxes.Ticks = tick9;
            // 
            // lblGoodMorning
            // 
            this.lblGoodMorning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoodMorning.AutoSize = false;
            this.lblGoodMorning.BackColor = System.Drawing.Color.Transparent;
            this.lblGoodMorning.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodMorning.ForeColor = System.Drawing.Color.White;
            this.lblGoodMorning.Location = new System.Drawing.Point(9, 3);
            this.lblGoodMorning.Name = "lblGoodMorning";
            this.lblGoodMorning.Size = new System.Drawing.Size(225, 54);
            this.lblGoodMorning.TabIndex = 6;
            this.lblGoodMorning.Text = "Good Morning,";
            this.lblGoodMorning.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoggedInDoctor
            // 
            this.lblLoggedInDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggedInDoctor.AutoSize = false;
            this.lblLoggedInDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggedInDoctor.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInDoctor.ForeColor = System.Drawing.Color.White;
            this.lblLoggedInDoctor.Location = new System.Drawing.Point(240, 3);
            this.lblLoggedInDoctor.Name = "lblLoggedInDoctor";
            this.lblLoggedInDoctor.Size = new System.Drawing.Size(169, 54);
            this.lblLoggedInDoctor.TabIndex = 7;
            this.lblLoggedInDoctor.Text = "Dr Adam";
            this.lblLoggedInDoctor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPasienName
            // 
            this.lblPasienName.AutoSize = false;
            this.lblPasienName.BackColor = System.Drawing.Color.Transparent;
            this.lblPasienName.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasienName.ForeColor = System.Drawing.Color.White;
            this.lblPasienName.Location = new System.Drawing.Point(9, 81);
            this.lblPasienName.Name = "lblPasienName";
            this.lblPasienName.Size = new System.Drawing.Size(185, 22);
            this.lblPasienName.TabIndex = 8;
            this.lblPasienName.Text = "Appointment Statistic";
            // 
            // btnMonthly
            // 
            this.btnMonthly.BackColor = System.Drawing.Color.Transparent;
            this.btnMonthly.BorderRadius = 10;
            this.btnMonthly.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMonthly.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMonthly.CheckedState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMonthly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonthly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonthly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonthly.FillColor = System.Drawing.Color.Transparent;
            this.btnMonthly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMonthly.ForeColor = System.Drawing.Color.White;
            this.btnMonthly.Location = new System.Drawing.Point(3, 3);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(92, 34);
            this.btnMonthly.TabIndex = 9;
            this.btnMonthly.Text = "Monthly";
            // 
            // btnWeekly
            // 
            this.btnWeekly.BackColor = System.Drawing.Color.Transparent;
            this.btnWeekly.BorderRadius = 10;
            this.btnWeekly.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWeekly.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnWeekly.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnWeekly.CheckedState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnWeekly.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWeekly.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWeekly.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWeekly.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWeekly.FillColor = System.Drawing.Color.Transparent;
            this.btnWeekly.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWeekly.ForeColor = System.Drawing.Color.White;
            this.btnWeekly.Location = new System.Drawing.Point(101, 4);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(86, 34);
            this.btnWeekly.TabIndex = 10;
            this.btnWeekly.Text = "Weekly";
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.Transparent;
            this.filterPanel.BorderRadius = 10;
            this.filterPanel.Controls.Add(this.btnDaily);
            this.filterPanel.Controls.Add(this.btnMonthly);
            this.filterPanel.Controls.Add(this.btnWeekly);
            this.filterPanel.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.filterPanel.Location = new System.Drawing.Point(268, 72);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(252, 41);
            this.filterPanel.TabIndex = 12;
            // 
            // btnDaily
            // 
            this.btnDaily.BackColor = System.Drawing.Color.Transparent;
            this.btnDaily.BorderRadius = 10;
            this.btnDaily.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDaily.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnDaily.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDaily.CheckedState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDaily.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDaily.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDaily.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDaily.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDaily.FillColor = System.Drawing.Color.Transparent;
            this.btnDaily.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDaily.ForeColor = System.Drawing.Color.White;
            this.btnDaily.Location = new System.Drawing.Point(193, 3);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(56, 34);
            this.btnDaily.TabIndex = 11;
            this.btnDaily.Text = "Daily";
            // 
            // OverviewChart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.lblPasienName);
            this.Controls.Add(this.lblLoggedInDoctor);
            this.Controls.Add(this.lblGoodMorning);
            this.Controls.Add(this.gunaChart1);
            this.Name = "OverviewChart";
            this.Size = new System.Drawing.Size(533, 330);
            this.filterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.Charts.WinForms.GunaChart gunaChart1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGoodMorning;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoggedInDoctor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPasienName;
        private Guna.UI2.WinForms.Guna2Button btnMonthly;
        private Guna.UI2.WinForms.Guna2Button btnWeekly;
        private Guna.UI2.WinForms.Guna2Panel filterPanel;
        private Guna.UI2.WinForms.Guna2Button btnDaily;
    }
}
