namespace Teatr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pnlMain = new Panel();
            pnlMenu = new Panel();
            btnDate = new Button();
            btnSell = new Button();
            btnSeance = new Button();
            btnTeatr = new Button();
            btnLogin = new Button();
            panel2 = new Panel();
            btnExit = new Button();
            btnMenu = new Button();
            forClr = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlMain);
            panel1.Controls.Add(pnlMenu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 656);
            panel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(50, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1160, 656);
            pnlMain.TabIndex = 2;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(0, 50, 0);
            pnlMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlMenu.Controls.Add(btnDate);
            pnlMenu.Controls.Add(btnSell);
            pnlMenu.Controls.Add(btnSeance);
            pnlMenu.Controls.Add(btnTeatr);
            pnlMenu.Controls.Add(btnLogin);
            pnlMenu.Controls.Add(panel2);
            pnlMenu.Controls.Add(btnExit);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(50, 656);
            pnlMenu.TabIndex = 1;
            // 
            // btnDate
            // 
            btnDate.Dock = DockStyle.Top;
            btnDate.FlatAppearance.BorderSize = 0;
            btnDate.FlatStyle = FlatStyle.Flat;
            btnDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDate.ForeColor = Color.White;
            btnDate.Location = new Point(0, 366);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(48, 45);
            btnDate.TabIndex = 8;
            btnDate.Text = "📆";
            btnDate.TextAlign = ContentAlignment.MiddleLeft;
            btnDate.UseVisualStyleBackColor = true;
            btnDate.Click += btnDate_Click;
            // 
            // btnSell
            // 
            btnSell.Dock = DockStyle.Bottom;
            btnSell.FlatAppearance.BorderSize = 0;
            btnSell.FlatStyle = FlatStyle.Flat;
            btnSell.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSell.ForeColor = Color.White;
            btnSell.Location = new Point(0, 564);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(48, 45);
            btnSell.TabIndex = 7;
            btnSell.Text = "\U0001f6d2";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // btnSeance
            // 
            btnSeance.Dock = DockStyle.Top;
            btnSeance.FlatAppearance.BorderSize = 0;
            btnSeance.FlatStyle = FlatStyle.Flat;
            btnSeance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeance.ForeColor = Color.White;
            btnSeance.Location = new Point(0, 321);
            btnSeance.Name = "btnSeance";
            btnSeance.Size = new Size(48, 45);
            btnSeance.TabIndex = 6;
            btnSeance.Text = "🎭";
            btnSeance.TextAlign = ContentAlignment.MiddleLeft;
            btnSeance.UseVisualStyleBackColor = true;
            btnSeance.Click += btnSeance_Click;
            // 
            // btnTeatr
            // 
            btnTeatr.Dock = DockStyle.Top;
            btnTeatr.FlatAppearance.BorderSize = 0;
            btnTeatr.FlatStyle = FlatStyle.Flat;
            btnTeatr.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTeatr.ForeColor = Color.White;
            btnTeatr.Location = new Point(0, 276);
            btnTeatr.Name = "btnTeatr";
            btnTeatr.Size = new Size(48, 45);
            btnTeatr.TabIndex = 5;
            btnTeatr.Text = "🏛️";
            btnTeatr.TextAlign = ContentAlignment.MiddleLeft;
            btnTeatr.UseVisualStyleBackColor = true;
            btnTeatr.Click += btnTeatr_Click;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Top;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(0, 231);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(48, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "🙂";
            btnLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.profil;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(48, 186);
            panel2.TabIndex = 3;
            panel2.Visible = false;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 609);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 45);
            btnExit.TabIndex = 2;
            btnExit.Text = "✖";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(48, 45);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "\U0001f7f0";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // forClr
            // 
            forClr.Enabled = true;
            forClr.Interval = 50;
            forClr.Tick += forClr_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 656);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Teatr";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlMenu;
        private Button btnExit;
        private Button btnMenu;
        private System.Windows.Forms.Timer forClr;
        private Panel panel2;
        private Button btnLogin;
        private Button btnDate;
        private Button btnSell;
        private Button btnSeance;
        private Button btnTeatr;
        private Panel pnlMain;
    }
}