using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_siniflarla_calismak
{
    class Fonksiyon
    {

        public Fonksiyon()
        {
            //
            // TODO : Add constructor logic here
            //
        }

        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data source = .; Initial Catalog = Kitaplar; UID = sa; password = 4532");
            baglanti.Open();
            return baglanti;
        }

        public int cmd(string sqlCumle)
        {
            SqlConnection connection = this.baglan();
            SqlCommand sorgu = new SqlCommand(sqlCumle,connection);
            int sonuc = 0;

            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + " (" + sqlCumle + ")");
            }
            finally
            {
                sorgu.Dispose();
                connection.Close();
            }

            return sonuc;
        }

        public DataTable GetDataTable(string sql)
        {
            SqlConnection connection = this.baglan();
            SqlDataAdapter da = new SqlDataAdapter(sql,connection);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "  (" + sql + ")  ");
            }
            finally
            {
                da.Dispose();
                connection.Close();
                connection.Dispose();
            }

            return dt;

        }

        public DataSet GetDataSet(string sql)
        {
            SqlConnection conn = this.baglan();
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "   (" + sql + ")  ");
            }
            finally
            {
                conn.Close();
                da.Dispose();
                conn.Dispose();
            }

            return ds;
        }


        public DataRow GetDataRow(string sql)
        {
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count == 0 )
            {
                return null;
            }

            return dt.Rows[0];
        }

        public string GetDataCell(string sql)
        {
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count == null)
            {
                return null;
            }

            return dt.Rows[0][0].ToString();
        }

    }
}
