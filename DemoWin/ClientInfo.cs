using DemoLib;
using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class ClientInfo : Form
    {
        public ClientInfo()
        {
            InitializeComponent();
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
        }

        public void SetClient(Client client)
        {
            CompanyNameTextBox.Text = client.Name;
            CompanyIDTextBox.Text = client.ID.ToString();
            PhoneNumberTextBox.Text=client.PhoneNumber;
            DirectorTextBox.Text=client.Director;
            TypeTextBox.Text=client.Type;
            RatingTextBox.Text=client.Rating.ToString();
            DiscountTextBox.Text=client.Discount.ToString();
        }

        private void CompanyNameTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void ClientInfo_Load(object sender, System.EventArgs e)
        {

        }
        private void exitButton_Click(object sender,EventArgs e)
        {
            this.Close();
        }

  
    }
}
