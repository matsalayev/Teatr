namespace Teatr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            forClr.Start();
        }
        int clr = 0;
        private void forClr_Tick(object sender, EventArgs e)
        {
            clr++;
            if (clr < 50) pnlMenu.BackColor = Color.FromArgb(clr, 50 - clr, clr);
            else if (clr < 100) pnlMenu.BackColor = Color.FromArgb(100 - clr, clr - 50, 100 - clr);
            else clr = 0;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (btnMenu.Text == "🟰")
            {
                pnlMenu.Width = 450;
                btnMenu.Text = " ◀️ Menyuni yopish";
                btnExit.Text = " ✖️ Dasturdan chiqish";
                btnLogin.Text = " 🙂 Mening hisobim";
                btnTeatr.Text = " 🏛️ Teatrlar ro'yxati";
                btnSeance.Text = " 🎭 Tomoshalar ro'yxati";
                btnDate.Text = " 📆 Sotuv bo'limi";
                btnSell.Text = " 🛒 Savat";
                panel2.Visible = true;
            }
            else
            {
                pnlMenu.Width = 50;
                btnMenu.Text = "🟰";
                btnExit.Text = "✖️";
                btnLogin.Text = "🙂";
                btnTeatr.Text = "🏛️";
                btnSeance.Text = "🎭";
                btnDate.Text = "📆";
                btnSell.Text = "🛒";
                panel2.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnTeatr_Click(object sender, EventArgs e)
        {

        }

        private void btnSeance_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Panel panel3 = new Panel();
                    Label label1 = new Label();
                    Label label2 = new Label();
                    PictureBox pictureBox1 = new PictureBox();


                    panel3.Controls.Add(label2);
                    panel3.Controls.Add(label1);
                    panel3.Controls.Add(pictureBox1);
                    panel3.Location = new Point(355 * i + 45, 355 * j + 35);
                    panel3.Name = "panel3";
                    panel3.Size = new Size(350, 50);
                    panel3.TabIndex = 0;
                    panel3.BorderStyle = BorderStyle.FixedSingle;
                    // 
                    // label1
                    // 
                    label1.AutoSize = true;
                    label1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    label1.Location = new Point(20, 210);
                    label1.Name = "label1";
                    label1.Size = new Size(143, 22);
                    label1.TabIndex = 1;
                    label1.Text = "Tomosha nomi";
                    // 
                    // pictureBox1
                    // 
                    pictureBox1.Image = Properties.Resources.Blue_Creative_2021_Windows_11_Dynamic_4K_HD_2880x1800;
                    pictureBox1.Location = new Point(20, 20);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new Size(210, 180);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.TabIndex = 0;
                    pictureBox1.TabStop = false;
                    // 
                    // label2
                    // 
                    label2.AutoSize = true;
                    label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                    label2.Location = new Point(110, 178);
                    label2.Name = "label2";
                    label2.Size = new Size(120, 22);
                    label2.TabIndex = 2;
                    label2.Text = "50 000 so'm";

                    //pnlMain.Controls.Add(panel3);
                }
            }
            */

        }

        private void btnDate_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {

        }
    }
}