using System;
using System.Data;
using System.Data.SqlClient;

namespace NguyenHoTruongTam_1150080156_Lap4_TH1
{
    public static class Db
    {
        private static readonly string _cnn =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Quanlybanhang;Integrated Security=True";

        public static SqlConnection GetConn()
        {
            var cnn = new SqlConnection(_cnn);
            cnn.Open();
            return cnn;
        }

        public static int ExecNonQuery(string sql, params SqlParameter[] ps)
        {
            using (var cn = GetConn())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecScalar(string sql, params SqlParameter[] ps)
        {
            using (var cn = GetConn())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                return cmd.ExecuteScalar();
            }
        }

        public static DataTable GetDataTable(string sql, params SqlParameter[] ps)
        {
            using (var cn = GetConn())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0) cmd.Parameters.AddRange(ps);
                using (var ad = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    ad.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
