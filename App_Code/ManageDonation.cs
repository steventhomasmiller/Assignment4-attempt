using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ManageVehicle
/// </summary>
public class ManageDonation
{
    SqlConnection connect;
    public ManageDonation()
	{
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityServiceConnectionString"].ConnectionString); //hmmm
	}

    public DataTable GetDonation(int personKey)
    {
        string sql = "Select PersonFirstName, PersonLastName, LicenseNumber, VehicleMake, VehicleYear from Customer.Vehicle inner Join Person on person.Personkey=Customer.Vehicle.Personkey where Person.personkey=@personkey"; //what???
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@personKey", personKey);
        SqlDataReader reader = null;
        DataTable table = new DataTable();
        connect.Open();
        reader = cmd.ExecuteReader();
        table.Load(reader);
        table.Dispose();
        connect.Close();
        
        return table;
    }
}