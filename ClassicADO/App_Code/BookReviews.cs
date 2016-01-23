using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class BookReviews
{
    SqlConnection connect;
	public BookReviews()
	{

        connect = new SqlConnection(ConfigurationManager.
            ConnectionStrings["BookReviewConnectionString"].ToString());
	}

    public DataTable GetAuthors()
    {
        string sql = "SELECT authorkey, authorname FROM Author";
        DataTable tbl;

        SqlCommand cmd = new SqlCommand(sql, connect);
        try
        {
         
            tbl = ProcessQuery(cmd);
        }
        catch(Exception ex)
        {
            
            throw ex;
        }
        return tbl;
        
    }
    public DataTable GetBooks(int authorKey)
    {
        string sql = "SELECT * FROM book INNER JOIN authorbook ON book.bookkey= authorbook.bookkey WHERE authorkey = @authorkey";
        SqlCommand cmd = new SqlCommand(sql, connect);
        
        cmd.Parameters.Add("@authorkey", authorKey);

        DataTable tbl;
        try
        {
            tbl = ProcessQuery(cmd);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return tbl;

    }

    private DataTable ProcessQuery(SqlCommand cmd)
    {
        DataTable table = new DataTable();
        SqlDataReader reader;
        try
        {
            connect.Open();
            reader = cmd.ExecuteReader();
            table.Load(reader);
            connect.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return table;
    }
}