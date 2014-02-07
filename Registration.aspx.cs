using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Customer c = new Customer();
        Donation d = new Donation();
        c.LastName = txtLastName.Text;
        c.FirstName = txtFirstName.Text;
        c.Email = txtEmail.Text;
        c.Password = txtConfirm.Text;

        d.DonationAmount = txtDonation.Text; //hmmm?
        

        ManagePerson mp = new ManagePerson(d, c);
        mp.WritePerson();
        mp.WriteRegisteredCustomer(); //???
        mp.WriteDonation();
        

        lblResult.Text = "Thank you for registering. We are ever so grateful.";
    }
}