using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.IO;
using System.Configuration;
using System.Globalization;
using System.Diagnostics;
using System.Xml;
using System.Windows.Forms;

public partial class Diskusage : System.Web.UI.Page
{
    string dir;
    
    DataSet dataset;
  
    protected void Page_Load(object sender, EventArgs e)
    {
        String id = Request.QueryString["id"];
        dir = ConfigurationManager.AppSettings["Systemcharts"];
        Chart1.Legends.Add(new Legend("Legend2"));
        Chart1.Legends["Legend2"].Docking = Docking.Right;
        dataset = CsvToDataTable(Int32.Parse(id));
        CsvToDataTable2(Int32.Parse(id));
        getcharts();
    }
    public DataSet CsvToDataTable(int id)
    {

        string[] file = new string[12]{ "sains01diskusage.csv", "ssl03diskusage.csv", "ssl04diskusage.csv", 
            "cvs01diskusage.csv", "cvs02diskusage.csv", "sobeyst1diskusage.csv", "madisont1diskusage.csv", "spartant1diskusage.csv", 
            "migrost1diskusage.csv","sonaet1diskusage.csv", "aeont1diskusage.csv" ,"icat1diskusage.csv"};
        DataSet set = new DataSet("clients");
        switch (id)
        {
            case 1:
                DataTable sains = new DataTable("SAINS_SS");
                set.Tables.Add(sains);
                Label1.Text = "Sainsbury's Data Retention Period:27 Months";
                DateTime d = DateTime.Now.AddMonths(-27);
                Label2.Text = "Data Earlier than"+" "+ d.ToShortDateString()+" "+ "can be archived.";
                    
                break;
            case 2:
                DataTable sslo3 = new DataTable("SSL03");
                set.Tables.Add(sslo3);
                Label1.Text = "Sainsbury's Data Retention Period is 27 Months";
                DateTime d1 = DateTime.Now.AddMonths(-27);
                Label2.Text = "Data Earlier than" + " " + d1.ToShortDateString() + " " + "can be archived.";
                break;
            case 3:
                DataTable sslo4 = new DataTable("SSL04");
                set.Tables.Add(sslo4);
                Label1.Text = "Sainsbury's Retention Period is 27 Months";
                DateTime d2 = DateTime.Now.AddMonths(-27);
                Label2.Text = "Data Earlier than" + " " + d2.ToShortDateString() + " " + "can be archived.";
                break;
            case 4:
                DataTable cvs01 = new DataTable("CVS01");
                set.Tables.Add(cvs01);
                Label1.Text = "CVS's Data Retention Period is 9 Quarters";
                DateTime d3 = DateTime.Now.AddMonths(-27);
                Label2.Text = "Data Earlier than" + " " + d3.ToShortDateString() + " " + "can be archived.";
                break;
            case 5:
                DataTable cvs02 = new DataTable("CVS02");
                set.Tables.Add(cvs02);
                Label1.Text = "CVS's Data Retention Period is 9 Quarters";
                DateTime d4 = DateTime.Now.AddMonths(-27);
                Label2.Text = "Data Earlier than" + " " + d4.ToShortDateString() + " " + "can be archived.";
                break;
            case 6:
                DataTable sobeys = new DataTable("SOBEYS01");
                set.Tables.Add(sobeys);
                
                break;
            case 7:
                DataTable madison = new DataTable("MADISON01");
                set.Tables.Add(madison);
                
                break;
            case 8:
                DataTable spartan = new DataTable("SPARTAN01");
                set.Tables.Add(spartan);
                Label1.Text = "Spartan's Data Retention Period is 130 Weeks";
                DateTime d5 = DateTime.Now.AddDays(-910);
                Label2.Text = "Data Earlier than" + " " + d5.ToShortDateString() + " " + "can be archived.";
                break;
            case 9:
                DataTable migros = new DataTable("MIGROS01");
                set.Tables.Add(migros);
                Label1.Text = "Migros's Data Retention Period is 104 Weeks";
                DateTime d6 = DateTime.Now.AddDays(-728);
                Label2.Text = "Data Earlier than" + " " + d6.ToShortDateString() + " " + "can be archived.";
                break;
            case 10:
                DataTable sonae = new DataTable("SONAE01");
                set.Tables.Add(sonae);
                Label1.Text = "Sonae's Data Retention Period is 36 Months";
                DateTime d7 = DateTime.Now.AddMonths(-36);
                Label2.Text = "Data Earlier than" + " " + d7.ToShortDateString() + " " + "can be archived.";
                break;
            case 11:
                DataTable aeon = new DataTable("AEON01");
                set.Tables.Add(aeon);
                Label1.Text = "Sonae's Data Retention Period is 130 Weeks";
                DateTime d8 = DateTime.Now.AddDays(-910);
                Label2.Text = "Data Earlier than" + " " + d8.ToShortDateString() + " " + "can be archived.";
                break;
            case 12:
                DataTable ica = new DataTable("ICA01");
                set.Tables.Add(ica);
                Label1.Text = "ICA's Data Retention Period is 27 Months";
                DateTime d9 = DateTime.Now.AddMonths(-27);
                Label2.Text = "Data Earlier than" + " " + d9.ToShortDateString() + " " + "can be archived.";
                break;
        }
        int i = 0;
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + dir + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\""))
        {
            conn.Open();
            string strQuery = "SELECT DISTINCT SLABGROUP,TOTPERCENT FROM [" + file[id - 1] + "] WHERE SLABDESC <> 'not allocated'";
            OleDbDataAdapter adapter =
                new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
            adapter.Fill(set.Tables[i]);
            conn.Close();
            // set.Tables[i].Rows[1].Delete();
            // set.Tables[i].Rows[0].Delete();
            set.Tables[i].AcceptChanges();
        }

        return set;
    }

    public void getcharts()
    {
        Chart1.Series["Series1"].ChartType = SeriesChartType.Column;
       
        Chart1.Series["Series1"].BorderWidth = 3;
        Chart1.Series["Series1"].IsValueShownAsLabel = false;
        Chart1.ChartAreas[0].AxisX.Interval = 1;
        Title t = Chart1.Titles.Add("Disk Usage Chart(Last Refreshed at 12:00AM GMT Today):");
        t.Font = new System.Drawing.Font("Times New Roman", 13, System.Drawing.FontStyle.Bold);
        t.ForeColor = System.Drawing.Color.FromArgb(0, 0, 225);
        Chart1.ChartAreas[0].AxisX.Title = "Slab Group Ids";
        Chart1.ChartAreas[0].AxisY.Title = "% Used";
      //Chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        Chart1.Series["Series1"]["DrawingStyle"] = "Emboss";
        Chart1.Series["Series1"].LegendText = dataset.Tables[0].TableName;
        Chart1.Series["Series1"].IsVisibleInLegend = true;

        Chart1.Series["Series1"].Points.DataBindXY(dataset.Tables[0].DefaultView, "SLABGROUP", dataset.Tables[0].DefaultView, "TOTPERCENT");
       
    }

    public void CsvToDataTable2(int id)
    {

        string[] file = new string[12]{ "sains01diskusage.csv", "ssl03diskusage.csv", "ssl04diskusage.csv", 
            "cvs01diskusage.csv", "cvs02diskusage.csv", "sobeyst1diskusage.csv", "madisont1diskusage.csv", "spartant1diskusage.csv", 
            "migrost1diskusage.csv","sonaet1diskusage.csv", "aeont1diskusage.csv" ,"icat1diskusage.csv"};
        DataSet set1 = new DataSet("clients");
        switch (id)
        {
            case 1:
                DataTable sains = new DataTable("SAINS_SS");
                set1.Tables.Add(sains);
                

                break;
            case 2:
                DataTable sslo3 = new DataTable("SSL03");
                set1.Tables.Add(sslo3);
               
                break;
            case 3:
                DataTable sslo4 = new DataTable("SSL04");
                set1.Tables.Add(sslo4);
               
                break;
            case 4:
                DataTable cvs01 = new DataTable("CVS01");
                set1.Tables.Add(cvs01);
               
                break;
            case 5:
                DataTable cvs02 = new DataTable("CVS02");
                set1.Tables.Add(cvs02);
                
                break;
            case 6:
                DataTable sobeys = new DataTable("SOBEYS01");
                set1.Tables.Add(sobeys);

                break;
            case 7:
                DataTable madison = new DataTable("MADISON01");
                set1.Tables.Add(madison);

                break;
            case 8:
                DataTable spartan = new DataTable("SPARTAN01");
                set1.Tables.Add(spartan);
                
                break;
            case 9:
                DataTable migros = new DataTable("MIGROS01");
                set1.Tables.Add(migros);
               
                break;
            case 10:
                DataTable sonae = new DataTable("SONAE01");
                set1.Tables.Add(sonae);
                
                break;
            case 11:
                DataTable aeon = new DataTable("AEON01");
                set1.Tables.Add(aeon);
                
                break;
            case 12:
                DataTable ica = new DataTable("ICA01");
                set1.Tables.Add(ica);
                
                break;
        }
        int i = 0;
        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + dir + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\""))
        {
            conn.Open();
            string strQuery = "SELECT  distinct SLABGROUP as SLABGRP,SLABDESC,SLAB FROM [" + file[id - 1] + "]";
            OleDbDataAdapter adapter =
                new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
            adapter.Fill(set1.Tables[i]);
            conn.Close();
            // set.Tables[i].Rows[1].Delete();
            // set.Tables[i].Rows[0].Delete();
            set1.Tables[i].AcceptChanges();
        }
        gridview1.DataSource = set1;
        gridview1.DataBind();
        

      
    }

}