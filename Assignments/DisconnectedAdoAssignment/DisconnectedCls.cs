using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedAdoAssignment
{
    internal class DisconnectedCls
    {
        SqlConnection con;
        SqlDataAdapter daEmp, daDept;
        DataSet ds;
        DataTable dt;

        public DisconnectedCls()
        {
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=infinitedb;server=ICS-LT-HQ4Q9K3");
            ds = new DataSet();
        }

        // Task-1
        public void DisplayEmployeeDepartment()
        {
            daEmp = new SqlDataAdapter("select * from employee", con);
            daDept = new SqlDataAdapter("select * from department", con);

            daEmp.Fill(ds, "emp");
            daDept.Fill(ds, "dept");

            Console.WriteLine("\nEMPLOYEE TABLE\n");
            foreach (DataRow row in ds.Tables["emp"].Rows)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4]);
            }

            Console.WriteLine("\nDEPARTMENT TABLE\n");
            foreach (DataRow row in ds.Tables["dept"].Rows)
            {
                Console.WriteLine(row[0] + " " + row[1]);
            }
        }
        //Task-2
        public void EmployeeDataView()
        {
            daEmp = new SqlDataAdapter("select * from employee", con);
            dt = new DataTable();
            daEmp.Fill(dt);

            DataView dv = new DataView(dt);
            dv.RowFilter = "salary > 47000 and deptid = 10 and empname like 'M%'";
            dv.Sort = "empname ASC";

            Console.WriteLine("\nFILTERED EMPLOYEES\n");
            foreach (DataRowView row in dv)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);
            }
        }

        //Task-3
        public void TotalTables()
        {
            Console.WriteLine("Total No Of Tables in DataSet = " + ds.Tables.Count);
        }

        //Task-4
        public void CopyReaderToDataTable()
        {
            SqlCommand cmd = new SqlCommand("select * from department", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dtDept = new DataTable();
            dtDept.Load(dr);

            con.Close();

            Console.WriteLine("\nDEPARTMENT FROM DATATABLE\n");
            foreach (DataRow row in dtDept.Rows)
            {
                Console.WriteLine(row[0] + " " + row[1]);
            }
        }

        //Task-5
        public void MergeCustomerOrders()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from customers", con);
            SqlDataAdapter da2 = new SqlDataAdapter("select * from orders", con);

            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();

            da1.Fill(ds1, "customers");
            da2.Fill(ds2, "orders");

            ds1.Merge(ds2);

            Console.WriteLine("\nMERGED DATASET\n");
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                        Console.Write(item + " ");

                    Console.WriteLine();
                }
            }
        }

        //Task-6
        public void ReadXmlData()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("C:\\Users\\humeras\\Infinite_Training\\Assignments\\CUSTOMER.xml");
            Console.WriteLine("\nXML DATA OUTPUT\n");
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine( row["CUSTID"] + " " + row["CUSTNAME"] + " " +
                        row["CUSTADDRESS"] + " " + row["PHONE"]
                    );
                }
            }
        }
    }
}
