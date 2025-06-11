using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SedapMakanChefModule
{
    public partial class Form1 : Form
    {
        private List<MenuItem> menuItems = new List<MenuItem>();
        private List<Order> orders = new List<Order>();
        private ChefProfile chefProfile = new ChefProfile();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
            LoadOrders();
            LoadChefProfile();
        }

        private void LoadMenuItems()
        {
            menuItems = DatabaseHelper.GetMenuItems();
            RefreshMenuList();
        }

        private void LoadOrders()
        {
            orders = DatabaseHelper.GetOrders();
            RefreshOrderList();
        }

        private void LoadChefProfile()
        {
            chefProfile = DatabaseHelper.GetChefProfile();
            txtUsername.Text = chefProfile.Username;
            txtPassword.Text = chefProfile.Password;
        }

        private void RefreshMenuList()
        {
            lstMenu.Items.Clear();
            foreach (var item in menuItems)
            {
                lstMenu.Items.Add(item);
            }
        }

        private void RefreshOrderList()
        {
            lstOrders.Items.Clear();
            foreach (var order in orders)
            {
                lstOrders.Items.Add(order);
            }
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMenuName.Text) || !decimal.TryParse(txtMenuPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid menu name and price.");
                return;
            }

            DatabaseHelper.AddMenuItem(txtMenuName.Text, price, chkMenuAvailable.Checked);
            LoadMenuItems();

            txtMenuName.Text = "";
            txtMenuPrice.Text = "";
            chkMenuAvailable.Checked = false;
        }

        private void btnToggleAvailability_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem is MenuItem selected)
            {
                bool newAvailability = !selected.IsAvailable;
                DatabaseHelper.UpdateMenuAvailability(selected.MenuItemId, newAvailability);
                LoadMenuItems();
            }
        }

        private void btnLoadOrders_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnUpdateOrderStatus_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItem is Order selected)
            {
                string newStatus = selected.Status;

                if (selected.Status == "Pending")
                {
                    newStatus = "In Progress";
                }
                else if (selected.Status == "In Progress")
                {
                    newStatus = "Completed";
                }
                else if (selected.Status == "Completed")
                {
                    newStatus = "Completed";
                }

                DatabaseHelper.UpdateOrderStatus(selected.OrderId, newStatus);
                LoadOrders();
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            DatabaseHelper.UpdateChefProfile(newUsername, newPassword);
            MessageBox.Show("Profile updated successfully.");
        }
    }
}
