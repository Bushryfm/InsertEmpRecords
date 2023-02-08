using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using InsertRecord.Models;
using System.Linq.Expressions;

namespace InsertRecord.Models
{
    public class Employeedb
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ULQ0ESS\\SQLEXPRESS;Initial Catalog=CoreMvcDB;Integrated Security=True");
        public String Saverecord(Employee emp)
       {
        try
        {

            SqlCommand com = new SqlCommand("Sp_Employee_Add",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Emp_Name", emp.Emp_Name);
            com.Parameters.AddWithValue("@City", emp.City);
            com.Parameters.AddWithValue("@State", emp.State);
            com.Parameters.AddWithValue("@Country", emp.Country);
            com.Parameters.AddWithValue("@Department", emp.Department);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            return ("OK");
        }
            catch (Exception ex)
        {
                if (con.State== ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }

    }
}
