namespace Calculate_Discount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double amount, discount, total,totalkh;
            amount = double.Parse(txtAmount.Text);
            if (amount <= 500)
            {
                discount = 0;
            }
            else if (amount <= 1000)
            {
                discount = amount * 0.03;
            }
            else if (amount <= 2000)
            {
                discount = amount * 0.05;
            }
            else
            {
                discount = amount * 0.7;
            }
            total = amount - discount;
            totalkh = total * 4000;
            txtDiscount.Text = discount.ToString();
            txtTotal.Text = total.ToString();
            txtTotalkh.Text=totalkh.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
