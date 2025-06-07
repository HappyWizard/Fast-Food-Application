namespace FastFoodApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomerControl1.BringToFront();
            panel3.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomerControl1.BringToFront();
            panel3.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            secondCustomerControl2.BringToFront();
            panel3.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
