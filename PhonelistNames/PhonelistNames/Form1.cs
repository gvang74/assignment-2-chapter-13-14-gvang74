using System;
using System.Windows.Forms;

namespace PhonelistNames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create a data context object.
            PhonelistDataContext db = new PhonelistDataContext();
            var results = from person in db.Persons
                          orderby person.Name
                          select person.Phone;

            //display all the name in the listbox.
            foreach (string name in results)
            {
                personListBox.Items.Add(name);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
