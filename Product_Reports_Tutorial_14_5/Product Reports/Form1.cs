//Gong_Vang
//CPT_206
//Chapter_14_Tutorial_14_5
//Pg_864

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Reports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void priceGT100Button_Click(object sender, EventArgs e)
        {
            //create a data context object
            ProductDBDataContext db = new ProductDBDataContext();

            //get the products with a price > 100
            var results = from product in db.Products
                          where product.Price > 100m
                          select product.Description;

            //clear the listbox
            descriptionListBox.Items.Clear();

            //display those prodycts' descriptions
            foreach (string description in results)
            {
                descriptionListBox.Items.Add(description);
            }
        }

        private void priceLT100Button_Click(object sender, EventArgs e)
        {
            //create a data context object
            ProductDBDataContext db = new ProductDBDataContext();

            //get the products with a price < 100
            var results = from product in db.Products
                          where product.Price < 100m
                          select product.Description;

            //clear the listbox
            descriptionListBox.Items.Clear();

            //display those prodycts' descriptions
            foreach (string description in results)
            {
                descriptionListBox.Items.Add(description);
            }
        }

        private void qtyGT100Button_Click(object sender, EventArgs e)
        {
            //create a data context object
            ProductDBDataContext db = new ProductDBDataContext();

            //get the products with units on hand > 100
            var results = from product in db.Products
                          where product.Units_On_Hand > 100
                          select product.Description;

            //clear the listbox
            descriptionListBox.Items.Clear();

            //display those prodycts' descriptions
            foreach (string description in results)
            {
                descriptionListBox.Items.Add(description);
            }
        }

        private void qtyLT100Button_Click(object sender, EventArgs e)
        {
            //create a data context object
            ProductDBDataContext db = new ProductDBDataContext();

            //get the products with units on hand < 100
            var results = from product in db.Products
                          where product.Units_On_Hand < 100
                          select product.Description;

            //clear the listbox
            descriptionListBox.Items.Clear();

            //display those products descriptions
            foreach (string description in results)
            {
                descriptionListBox.Items.Add(description);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();   
        }
    }
}
