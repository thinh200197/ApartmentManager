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
    }
}
