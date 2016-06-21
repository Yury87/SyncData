using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncData
{
    class IAData
    {
        private string _startdt = "01.01.2016 00:00";
        private string _enddt = DateTime.Now.ToString("dd.MM.yyyy 23:59");
        public List<IABillsHelper> BillsData;


        public IAData()
        {
            BillsData = new List<IABillsHelper>();
        }
        public void GetData()
        {
            string ConnectionString = "User ID=sysdba;Password=masterkey;" +
               "Database=server/3052:e:\\iadb\\IAPTEKA.fdb; " +
               "DataSource=server;Charset=NONE;";
            FbConnection addDetailsConnection = new FbConnection(ConnectionString);
            addDetailsConnection.Open();
            FbCommand readCommand =
                    new FbCommand("SELECT BILLS.DOC_ID, BILLS.SMEN_ID, BILLS.PAYMENT, BILLS.SALETYPE, BILLS.DISCOUNT, BILLS.DCARD,BILLS.BCARD,BILLS.BCARD_TYPE,BILLS.BONUS_BEFORE, BILLS.BONUS_ADD,BILLS.BONUS_LIMIT,BILLS.BONUS_PAY,BILLS.BONUS_ENABLE " +
                      "FROM BILLS, DOCS WHERE BILLS.DOC_ID=DOCS.DOC_ID and DOCS.CLOSEDATE between '" + _startdt
                       + "' and '" + _enddt +"'", addDetailsConnection);
            FbDataReader myreader = readCommand.ExecuteReader();
            while (myreader.Read())
            {
                IABillsHelper a =  new IABillsHelper();
                a.DocId = Convert.ToInt64(myreader[0]);
                a.SmenId = Convert.ToInt64(myreader[1]);
                a.Payment = Convert.ToInt32(myreader[2]);
                a.Saletype = Convert.ToInt32(myreader[3]);
                a.Discount = Convert.ToInt32(myreader[4]);
                a.DCard = (myreader[5].ToString() != "") ? Convert.ToInt64(myreader[5]) : 0;
                a.BCard = myreader[6].ToString();
                    a.BCardType = (myreader[7].ToString() != "") ? Convert.ToInt32(myreader[7]) : 0;
                a.BonusBefore = (myreader[8].ToString() != "") ? Convert.ToInt32(myreader[8]) : 0;
                a.BonusAdd = (myreader[9].ToString() != "") ? Convert.ToInt32(myreader[9]) : 0;
                a.BonusLimit = (myreader[10].ToString() != "") ? Convert.ToInt32(myreader[10]) : 0;
                a.BonusPay = (myreader[11].ToString() != "") ? Convert.ToInt32(myreader[11]) : 0;
                a.BonusEnable = (myreader[12].ToString() != "") ? Convert.ToInt32(myreader[12]) : 0;
                BillsData.Add(a);
            }
            myreader.Close();
            addDetailsConnection.Close();
            SetData();
        }

        private void SetData()
        {
            IADataClassessDataContext db = new IADataClassessDataContext();
            DataTable BillData = new DataTable();
            BillData.Columns.Add("DOC_ID", typeof(long));
            BillData.Columns.Add("BCARD", typeof(string));
            BillData.Columns.Add("BCARD_TYPE", typeof(Int16));
            BillData.Columns.Add("BONUS_ADD", typeof(int));
            BillData.Columns.Add("BONUS_BEFORE", typeof(int));
            BillData.Columns.Add("BONUS_ENABLE", typeof(int));
            BillData.Columns.Add("BONUS_LIMIT", typeof(int));
            BillData.Columns.Add("BONUS_PAY", typeof(int));
            BillData.Columns.Add("DCARD", typeof(long));
            BillData.Columns.Add("DISCOUNT", typeof(double));
            BillData.Columns.Add("PAYMENT", typeof(int));
            BillData.Columns.Add("SALETYPE", typeof(int));
            BillData.Columns.Add("SMEN_ID", typeof(long));
            foreach (var item in BillsData)
            {
                BillData.Rows.Add(item.DocId, item.BCard, Convert.ToInt16(item.BCardType), item.BonusAdd, item.BonusBefore, item.BonusEnable,
                    item.BonusLimit, item.BonusPay, item.DCard, item.Discount, item.Payment, item.Saletype, item.SmenId);


              /*  BILL bill = new BILL();
                bill.DOC_ID = item.DocId;
                bill.BCARD = item.BCard;
                bill.BCARD_TYPE = Convert.ToInt16(item.BCardType);
                bill.BONUS_ADD = item.BonusAdd;
                bill.BONUS_BEFORE = item.BonusBefore;
                bill.BONUS_ENABLE = item.BonusEnable;
                bill.BONUS_LIMIT = item.BonusLimit;
                bill.BONUS_PAY = item.BonusPay;
                bill.DCARD = item.DCard;
                bill.DISCOUNT = Convert.ToDecimal(item.Discount);
                bill.PAYMENT = item.Payment;
                bill.SALETYPE = item.Saletype;
                bill.SMEN_ID = item.SmenId;
                db.BILLs.InsertOnSubmit(bill);
                db.SubmitChanges();*/
            }
            string MSConnectionStr = "data source=192.168.1.39;persist security info=True;" +
                "user id=ftp;password=Sekret123;" +
                "MultipleActiveResultSets=True;Connection Timeout=60";
            using (SqlBulkCopy dt = new SqlBulkCopy(MSConnectionStr))
            {
                dt.BatchSize = 10000;
                dt.BulkCopyTimeout = 10000;
                dt.ColumnMappings.Add("DOC_ID", "DOC_ID");
                dt.ColumnMappings.Add("SMEN_ID", "SMEN_ID");
                dt.ColumnMappings.Add("PAYMENT", "PAYMENT");
                dt.ColumnMappings.Add("BCARD", "BCARD");
                dt.ColumnMappings.Add("BCARD_TYPE", "BCARD_TYPE");
                dt.ColumnMappings.Add("BONUS_ADD", "BONUS_ADD");
                dt.ColumnMappings.Add("BONUS_BEFORE", "BONUS_BEFORE");
                dt.ColumnMappings.Add("BONUS_LIMIT", "BONUS_LIMIT");
                dt.ColumnMappings.Add("DCARD", "DCARD");
                dt.ColumnMappings.Add("DISCOUNT", "DISCOUNT");
                dt.ColumnMappings.Add("SALETYPE", "SALETYPE");
                dt.ColumnMappings.Add("BONUS_ENABLE", "BONUS_ENABLE");
                dt.ColumnMappings.Add("BONUS_PAY", "BONUS_PAY");
                dt.DestinationTableName = "[dwh].[dbo].[BILLS]";
                dt.WriteToServer(BillData);
            }       

        }

    }


    public class IABillsHelper
    {
        public long DocId { get; set; }
        public long SmenId { get; set; }
        public int Payment { get; set; }
        public int Saletype { get; set; }
        public double Discount { get; set; }
        public long DCard { get; set; }
        public string BCard { get; set; }
        public int BCardType { get; set; }
        public int BonusBefore { get; set; }
        public int BonusAdd { get; set; }
        public int BonusLimit { get; set; }
        public int BonusPay { get; set; }
        public int BonusEnable { get; set; }
    }
}
