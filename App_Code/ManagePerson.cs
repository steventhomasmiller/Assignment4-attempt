using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ManagePerson
/// </summary>
public class ManagePerson
{
    private Donation d;
    private Customer c;
    private SqlConnection connect;

	public ManagePerson(Donation don, Customer cust)
	{
        d = don;
        c = cust;
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["AutomartConnectionString"].ConnectionString);//WHAT?!!!?
	}

    public void WritePerson()
    {
        string sql = "Insert into Person(PersonLastName, PersonFirstName) Values (@Last, @first)";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@Last", c.LastName);
        cmd.Parameters.AddWithValue("@first", c.FirstName);

        connect.Open();
        cmd.ExecuteNonQuery(); //an error will probably fall into one of these two linds
        connect.Close();
    }

    public void WriteRegisteredCustomer()
    {
        string sql = "Insert into Customer.RegisteredCustomer(Email, CustomerPassword, CustomerPassCode, CustomerHashedPassword, PersonKey) Values (@Email, @Password, @PassCode, @hash, Ident_Current('Person'))";

        PassCodeGenerator psg = new PassCodeGenerator();
        int passcode = psg.GetPassCode();
        PasswordHash ph = new PasswordHash();

        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@Email", c.Email);
        cmd.Parameters.AddWithValue("@Password", c.Password);
        cmd.Parameters.AddWithValue("@PassCode", passcode);
        cmd.Parameters.AddWithValue("@hash", ph.Hashit(c.Password, passcode.ToString()));

        connect.Open();
        cmd.ExecuteNonQuery(); //an error will probably fall into one of these two linds
        connect.Close();
    }

    public void WriteDonation()
    {
        string sql = "Insert into Customer.Vehicle(LicenseNumber, VehicleMake, VehicleYear, PersonKey) Values (@Number, @Make, @Year, Ident_Current('Person'))";//note sure here
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@Amount", d.LicenseNumber);

        connect.Open();
        cmd.ExecuteNonQuery(); //an error will probably fall into one of these two kinds
        connect.Close(); 
    }
}