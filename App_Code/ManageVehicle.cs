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
public class ManageVehicle
{
    SqlConnection connect;
    public ManageVehicle()
	{
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["AutomartConnectionString"].ConnectionString); //hmmm
	}

    public DataTable GetVehicle(int personKey)
    {
        string sql = "Select FirstName, LastName, LicenseNumber, VehicleMake, VehicleYear from Customer.Vehicle inner Join Person on person.Personkey=Customer.Vehicle.Personkey where Person.personkey=@personkey";
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