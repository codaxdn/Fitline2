using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


public class CConexion : IDisposable
{
	public CConexion()
	{
		MySqlConnection con = new MySqlConnection();
        String Password = "";
        string bd = "gym";
        string conexion = "Server = localhost; port = 3306; user id = root; password = " + Password + " ; database = " + bd + ";";

    }
    public MySqlConnection establecerConexion()
    {
        MySqlConnection con = new MySqlConnection();
        try
        {
            String Password = "";
            string bd = "gym";
            string conexion = "Server = localhost; port = 3306; user id = root; password = " + Password + " ; database = " + bd + ";";
            con.ConnectionString = conexion;
            con.Open();
            Console.WriteLine("se logro conectar a la base de datos de forma correcta");
        }
        catch (MySqlException e)
        {
            MessageBox.Show("no se pudo conectar la base de datos" + e.ToString());
        }
        return con;


    }
    public void CerrarConexion()
    {
        MySqlConnection con = new MySqlConnection();
        con.Close();
    }
    public void Dispose()
    {
        // Liberar los recursos en uso
        MySqlConnection con = new MySqlConnection();
        con.Close();
    }

}
