//Gong_Vang
//CPT_206
//Tutorial_14_6
//Completing the QueryDataSource Applaction 
//Pg_871

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Query_Data_Source_Tutorial_14_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create a data context object 
            ProductDBDataContext db = new ProductDBDataContext();

            //get all the product object from the product collection
            var results = from product in db.Products
                          select product;

            //assign the results of the query to the datagridview control
            productDataGridView.DataSource = results;
        }

        private void ChangeUpdateButton_Click(object sender, EventArgs e)
        {
            //create a data context object 
            ProductDBDataContext db = new ProductDBDataContext();

            //changes product's price and updates database with new row
            Product prod = db.Products.FirstOrDefault(item =>
                                item.Product_Number == "10-04");

            if (prod != null ) 
            {
                prod.Price = 99.99m;
                db.SubmitChanges();
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //create a data context object 
            ProductDBDataContext db = new ProductDBDataContext();
            
            //returms all products that have a product number property containing 10-; and loop and returned changing units on hands to 0.; and updates database with new data.
            var results = from prod in db.Products
                          where prod.Product_Number.Contains("10-")
                          select prod;

            foreach(Product p in results)
            {
                p.Units_On_Hand = 0;
            }

            db.SubmitChanges();


        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            //create a data context object 
            ProductDBDataContext db = new ProductDBDataContext();

            //new row being into the database table
            Product prod = new Product();
            prod.Product_Number = "40-01";
            prod.Description = "Hiking Boots";
            prod.Units_On_Hand = 10;
            prod.Price = 299m;

            db.Products.InsertOnSubmit(prod);
            db.SubmitChanges();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //create a data context object 
            ProductDBDataContext db = new ProductDBDataContext();

            //deleting an item from database table
            Product prod = db.Products.FirstOrDefault(item => item.Product_Number == "10-04");

            if ( prod != null ) 
            {
                db.Products.DeleteOnSubmit(prod);
                db.SubmitChanges();
            }


        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //close program
            this.Close();
        }
    }
}
