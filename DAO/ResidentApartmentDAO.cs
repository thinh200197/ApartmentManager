using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManager.DAO
{
    public class ResidentApartmentDAO
    {
        private static ResidentApartmentDAO instance;
        public static ResidentApartmentDAO Instance
        {
            get { if (instance == null) instance = new ResidentApartmentDAO(); return instance; }
            private set => instance = value;
        }
        private ResidentApartmentDAO() { }

        public DataTable GetAllResidentApartment()
        {
            string query = "select * from [CUDAN-CANHO]";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool Insert(string maCanHo,string maCuDan)
        {
            string querySearchCuDan = "SELECT * FROM CUDAN WHERE MACUDAN = '"+ maCuDan+"'";
            string querySearchCanHo = "SELECT * FROM CANHO WHERE MACANHO = '"+ maCanHo+"'";

            var cuDan = DataProvider.Instance.ExecuteQuery(querySearchCuDan, new object[] { maCuDan});
            var canHo = DataProvider.Instance.ExecuteQuery(querySearchCanHo, new object[] { maCanHo });

            if (cuDan == null || canHo == null)
            {
                return false;
            }

            string query = "PR_InserResidentApartment @MaCuDan , @MaCanHo";
            int data = DataProvider.Instance.ExecuteNonQuery(query,new object[]{ maCuDan, maCanHo });
            return data > 0;
        }
        public bool Update(int id ,string maCanHo, string maCuDan, DateTime ngayVaoO,DateTime ngayHetO)
        {
            string query = "PR_UpdateResidentApartment @id ,@MaCuDan , @MaCanHo , @ngayVaoO , @ngayHetO ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {id, maCuDan, maCanHo ,ngayVaoO,ngayHetO});
            return data > 0;
        }
    }
}
