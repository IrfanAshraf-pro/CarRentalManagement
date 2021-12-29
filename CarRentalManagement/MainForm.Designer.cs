
namespace CarRentalManagement
{
    partial class MainForm
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
            this.xuiSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.btnDashboard = new XanderUI.XUISuperButton();
            this.btnAvailable = new XanderUI.XUISuperButton();
            this.btnReturn = new XanderUI.XUISuperButton();
            this.btnRental = new XanderUI.XUISuperButton();
            this.btnCustomer = new XanderUI.XUISuperButton();
            this.btnAddCar = new XanderUI.XUISuperButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMainShowForms = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.xuiSlidingPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.xuiGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiSlidingPanel1
            // 
            this.xuiSlidingPanel1.BottomLeft = System.Drawing.Color.Indigo;
            this.xuiSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuiSlidingPanel1.CollapseControl = null;
            this.xuiSlidingPanel1.Collapsed = true;
            this.xuiSlidingPanel1.Controls.Add(this.btnDashboard);
            this.xuiSlidingPanel1.Controls.Add(this.btnAvailable);
            this.xuiSlidingPanel1.Controls.Add(this.btnReturn);
            this.xuiSlidingPanel1.Controls.Add(this.btnRental);
            this.xuiSlidingPanel1.Controls.Add(this.btnCustomer);
            this.xuiSlidingPanel1.Controls.Add(this.btnAddCar);
            this.xuiSlidingPanel1.Controls.Add(this.pictureBox1);
            this.xuiSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuiSlidingPanel1.HideControls = false;
            this.xuiSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiSlidingPanel1.Name = "xuiSlidingPanel1";
            this.xuiSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuiSlidingPanel1.PanelWidthExpanded = 200;
            this.xuiSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiSlidingPanel1.Size = new System.Drawing.Size(230, 710);
            this.xuiSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanel1.TabIndex = 3;
            this.xuiSlidingPanel1.TopLeft = System.Drawing.Color.BlueViolet;
            this.xuiSlidingPanel1.TopRight = System.Drawing.Color.DodgerBlue;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnDashboard.ButtonImage = global::CarRentalManagement.Properties.Resources.available_removebg_preview;
            this.btnDashboard.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnDashboard.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnDashboard.ButtonText = "DashBoard";
            this.btnDashboard.CornerRadius = 24;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDashboard.HoverBackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnDashboard.HoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnDashboard.Location = new System.Drawing.Point(9, 479);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.SelectedBackColor = System.Drawing.Color.BlueViolet;
            this.btnDashboard.SelectedTextColor = System.Drawing.Color.White;
            this.btnDashboard.Size = new System.Drawing.Size(205, 40);
            this.btnDashboard.SuperSelected = false;
            this.btnDashboard.TabIndex = 9;
            this.btnDashboard.TextColor = System.Drawing.Color.White;
            this.btnDashboard.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnAvailable
            // 
            this.btnAvailable.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnAvailable.ButtonImage = global::CarRentalManagement.Properties.Resources.available_removebg_preview;
            this.btnAvailable.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnAvailable.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnAvailable.ButtonText = "Available";
            this.btnAvailable.CornerRadius = 24;
            this.btnAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailable.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAvailable.HoverBackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnAvailable.HoverTextColor = System.Drawing.Color.White;
            this.btnAvailable.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnAvailable.Location = new System.Drawing.Point(11, 418);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.SelectedBackColor = System.Drawing.Color.BlueViolet;
            this.btnAvailable.SelectedTextColor = System.Drawing.Color.White;
            this.btnAvailable.Size = new System.Drawing.Size(205, 40);
            this.btnAvailable.SuperSelected = false;
            this.btnAvailable.TabIndex = 8;
            this.btnAvailable.TextColor = System.Drawing.Color.White;
            this.btnAvailable.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnReturn.ButtonImage = global::CarRentalManagement.Properties.Resources.return_removebg_preview;
            this.btnReturn.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnReturn.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnReturn.ButtonText = "Return";
            this.btnReturn.CornerRadius = 24;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReturn.HoverBackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnReturn.HoverTextColor = System.Drawing.Color.White;
            this.btnReturn.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnReturn.Location = new System.Drawing.Point(11, 357);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.SelectedBackColor = System.Drawing.Color.BlueViolet;
            this.btnReturn.SelectedTextColor = System.Drawing.Color.White;
            this.btnReturn.Size = new System.Drawing.Size(205, 40);
            this.btnReturn.SuperSelected = false;
            this.btnReturn.TabIndex = 7;
            this.btnReturn.TextColor = System.Drawing.Color.White;
            this.btnReturn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnRental
            // 
            this.btnRental.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnRental.ButtonImage = global::CarRentalManagement.Properties.Resources.rent_removebg_preview__1_;
            this.btnRental.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnRental.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnRental.ButtonText = "Rental";
            this.btnRental.CornerRadius = 24;
            this.btnRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRental.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRental.HoverBackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnRental.HoverTextColor = System.Drawing.Color.White;
            this.btnRental.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnRental.Location = new System.Drawing.Point(9, 293);
            this.btnRental.Name = "btnRental";
            this.btnRental.SelectedBackColor = System.Drawing.Color.BlueViolet;
            this.btnRental.SelectedTextColor = System.Drawing.Color.White;
            this.btnRental.Size = new System.Drawing.Size(205, 40);
            this.btnRental.SuperSelected = false;
            this.btnRental.TabIndex = 6;
            this.btnRental.TextColor = System.Drawing.Color.White;
            this.btnRental.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnCustomer.ButtonImage = global::CarRentalManagement.Properties.Resources.iconwhite_removebg_preview;
            this.btnCustomer.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnCustomer.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnCustomer.ButtonText = "Customer";
            this.btnCustomer.CornerRadius = 24;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCustomer.HoverBackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnCustomer.HoverTextColor = System.Drawing.Color.White;
            this.btnCustomer.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnCustomer.Location = new System.Drawing.Point(9, 228);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.SelectedBackColor = System.Drawing.Color.BlueViolet;
            this.btnCustomer.SelectedTextColor = System.Drawing.Color.White;
            this.btnCustomer.Size = new System.Drawing.Size(205, 40);
            this.btnCustomer.SuperSelected = false;
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.TextColor = System.Drawing.Color.White;
            this.btnCustomer.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnAddCar.ButtonImage = global::CarRentalManagement.Properties.Resources.caricon_removebg_preview;
            this.btnAddCar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnAddCar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnAddCar.ButtonText = "Car";
            this.btnAddCar.CornerRadius = 24;
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCar.HoverBackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnAddCar.HoverTextColor = System.Drawing.Color.White;
            this.btnAddCar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnAddCar.Location = new System.Drawing.Point(9, 160);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.SelectedBackColor = System.Drawing.Color.BlueViolet;
            this.btnAddCar.SelectedTextColor = System.Drawing.Color.White;
            this.btnAddCar.Size = new System.Drawing.Size(205, 40);
            this.btnAddCar.SuperSelected = false;
            this.btnAddCar.TabIndex = 4;
            this.btnAddCar.TextColor = System.Drawing.Color.White;
            this.btnAddCar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CarRentalManagement.Properties.Resources._2020_charger_srt_thumb_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.DodgerBlue;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Indigo;
            this.xuiGradientPanel1.Controls.Add(this.label1);
            this.xuiGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(230, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(889, 104);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 4;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DodgerBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.BlueViolet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 30F);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental Management System";
            // 
            // panelMainShowForms
            // 
            this.panelMainShowForms.BackColor = System.Drawing.Color.Snow;
            this.panelMainShowForms.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMainShowForms.Location = new System.Drawing.Point(251, 104);
            this.panelMainShowForms.Name = "panelMainShowForms";
            this.panelMainShowForms.Size = new System.Drawing.Size(868, 606);
            this.panelMainShowForms.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRentalManagement.Properties.Resources.border;
            this.pictureBox2.Location = new System.Drawing.Point(-118, -108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 963);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 710);
            this.Controls.Add(this.panelMainShowForms);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.xuiSlidingPanel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.xuiSlidingPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private XanderUI.XUISlidingPanel xuiSlidingPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Panel panelMainShowForms;
        private XanderUI.XUISuperButton btnAddCar;
        private XanderUI.XUISuperButton btnRental;
        private XanderUI.XUISuperButton btnCustomer;
        private XanderUI.XUISuperButton btnReturn;
        private XanderUI.XUISuperButton btnAvailable;
        private XanderUI.XUISuperButton btnDashboard;
        private System.Windows.Forms.Label label1;
    }
}