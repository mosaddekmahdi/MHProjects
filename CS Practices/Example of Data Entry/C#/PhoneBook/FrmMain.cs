// Import the framework of the Libraries
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Data.Entity;

// PhoneBook project
namespace PhoneBook
{
    // class FrmMain
    public partial class FrmMain : Form
    {
        // FrmMain class constructor
        public FrmMain()
        {
            // method InitializeComponent
            InitializeComponent();
        }

        // Button's click event btnAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // I declare a new instance of the class PhoneBookContext
            using (PhoneBookContext pnctx = new PhoneBookContext())
            {
                // I declare a new instance of the class Person
                Person NewPerson = new Person();
                // Enhance the name field of the Person class with the contents of txtName
                NewPerson.NAME = this.txtName.Text;
                // Enhance the surname field of the Person class with the contents of txtSurName
                NewPerson.SURNAME = this.txtSurname.Text;
                // Enhance the telephonenumber field of the Person class with the contents of txtTelephoneNumber
                NewPerson.TELEPHONENUMBER = this.txtTelephoneNumber.Text;
                // Enhance the mobile field of the Person class with the contents of txtMobile
                NewPerson.MOBILE = this.txtMobile.Text;
                // Adds the given entity to the context the Added state. 
                //When the changes are being saved, the entities in the Added states are inserted into the database. 
                //After the changes are saved, the object state changes to Unchanged.
                pnctx.Persons.Add(NewPerson);

                // Iterates to check the validation of input data in the database, 
                //in case of validation errors will be displayed to the user a message or invalid fields.
                foreach (DbEntityValidationResult validationResult in pnctx.GetValidationErrors())
                {
                    foreach (DbValidationError validationerror in validationResult.ValidationErrors)
                    {
                        MessageBox.Show(validationerror.PropertyName + ":" + validationerror.ErrorMessage.ToString());
                        // go to exit label
                        goto exit;
                    }
                }

                // Saves all changes made in this context, to the underlying in database
                pnctx.SaveChanges();

            // exit label
            exit: ;
            }
        }

        // Button's click event btnFind
        private void btnFind_Click(object sender, EventArgs e)
        {
            // Clear all rows the dgvPerson
            this.dgvPerson.Rows.Clear();

            // I declare a new instance of the class PhoneBookContext
            using (PhoneBookContext ctx = new PhoneBookContext())
            {
                // I declare a new instance of the class FindPerson
                FindPerson person = new FindPerson();
                {
                    // and true if checkbox rbName
                    if (rbName.Checked.Equals(true))
                    {
                        // Cheque by reference to the function result dgvPerson DetailPerson depending on the type of research performed
                        this.dgvPerson = person.DetailPerson(ctx, this.rbName.Checked,this.txtFind.Text,"NAME",this.dgvPerson);
                    }

                    // and true if checkbox rbSurname
                    if (rbSurname.Checked.Equals(true))
                    {
                        // Cheque by reference to the function result dgvPerson DetailPerson depending on the type of research performed
                        this.dgvPerson = person.DetailPerson(ctx, this.rbSurname.Checked, this.txtFind.Text, "SURNAME", this.dgvPerson);
                    }

                    // and true if checkbox rbPhoneNumber
                    if (rbPhoneNumber.Checked.Equals(true))
                    {
                        // Cheque by reference to the function result dgvPerson DetailPerson depending on the type of research performed
                        this.dgvPerson = person.DetailPerson(ctx, this.rbPhoneNumber.Checked, this.txtFind.Text, "TELEPHONENUMBER", this.dgvPerson);
                    }

                    // and true if checkbox rbMobile
                    if (rbMobile.Checked.Equals(true))
                    {
                        // Cheque by reference to the function result dgvPerson DetailPerson depending on the type of research performed
                        this.dgvPerson = person.DetailPerson(ctx, this.rbMobile.Checked, this.txtFind.Text, "MOBILE", this.dgvPerson);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}