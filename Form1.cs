using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;
using System.IO;
using PantryManager;

namespace Pantry_Manager
{
    public partial class Form1 : Form
    {
        // This list will hold all our pantry items
        private List<PantryItem> myInventory = new List<PantryItem>();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {// 1. Extract the quantity and name
            string name = txtName.Text;
            bool isNumber = int.TryParse(txtQuantity.Text, out int qty);

            // 2. The Gatekeeper: Check for valid inputs
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("We need an item name before we can add it!");
                return; // Stops the code here
            }

            if (!isNumber || qty <= 0)
            {
                MessageBox.Show("Please enter a quantity greater than zero.");
                return; // Stops the code here
            }

            // 3. If we passed the gatekeeper, we can finally add the item
            PantryItem newItem = new PantryItem
            {
                Name = name,
                Quantity = qty,
                ExpirationDate = dtpExpiry.Value
            };

            myInventory.Add(newItem);
            UpdateGrid();
            SaveData();

            // Clear for next time
            txtName.Clear();
            txtQuantity.Clear();
        }
        private void UpdateGrid()
        {
            dgvInventory.DataSource = null; // Reset
            dgvInventory.DataSource = myInventory; // Show updated list
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow != null)
            {
                // 1. Get the item currently selected in the grid
                PantryItem selectedItem = (PantryItem)dgvInventory.CurrentRow.DataBoundItem;

                // 2. Check if we have stock
                if (selectedItem.Quantity > 0)
                {
                    selectedItem.Quantity--; // Decrease by 1

                    if (selectedItem.Quantity == 0)
                    {
                        MessageBox.Show($"{selectedItem.Name} is now out of stock!");
                    }
                }
                else
                {
                    MessageBox.Show("Cannot use item: Quantity is already zero.");
                }

                // 3. Refresh the grid and save
                UpdateGrid();
                SaveData(); // We will create this function next!
            }
        }

        private string filePath = "pantry.json";

private void SaveData()
{
    // Converts our list into a JSON string
    string jsonString = JsonSerializer.Serialize(myInventory);
    File.WriteAllText(filePath, jsonString);
}

private void LoadData()
{
    if (File.Exists(filePath))
    {
        // Reads the file and turns it back into a List
        string jsonString = File.ReadAllText(filePath);
        myInventory = JsonSerializer.Deserialize<List<PantryItem>>(jsonString);
        UpdateGrid();
    }
}

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
