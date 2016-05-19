using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using Microsoft.Office;
using System.Data.OleDb;
using System.Configuration;
using System.Text;
using System.Net.Mail;
using System.Drawing.Design;
using System.Web.UI.WebControls.WebParts;
using System.Drawing;

public partial class RamUsage : System.Web.UI.Page
{
    String dir3 = "";
    const string Normal = "NORMAL";
    const string Critical = "CRITICAL";
    const string Warning  = "WARNING";


    char[] delimiterChars = { ' ' };

    protected void Page_Load(object sender, EventArgs e)
    {
        ColorCodingforRam();
        ColorCodingforDisk();
    }
    private void ColorCodingforRam()
    {
        dir3 = ConfigurationManager.AppSettings["Ramstats"];

        string[] subdirEntries = Directory.GetDirectories(dir3);
        foreach (string d in subdirEntries)
        {
            DirectoryInfo di = new DirectoryInfo(d);

            FileInfo[] f = di.GetFiles();
            DateTime lastWrite = DateTime.MinValue;
            FileInfo lastWritenFile = null;

            String diname = di.Name.ToString();
            int count = 0;

            count = f.Length;
            if (count != 0)
            {
                foreach (FileInfo file in f)
                {
                    DateTime lastWritedelete = file.LastWriteTime;

                    TimeSpan ts = DateTime.UtcNow.Date.Subtract(file.LastWriteTime.Date);

                    if (ts.Hours > 2)
                    { file.Delete();
                    }

                    if ((file.LastWriteTime > lastWrite) && (file.LastWriteTime.Date == DateTime.UtcNow.Date))
                    {
                        lastWrite = file.LastWriteTime;
                        lastWritenFile = file;
                    }

                    if (lastWritenFile != null)
                    {
                        lastWritenFile = file;
                        String ff = lastWritenFile.Name.ToString();
                        String[] words = ff.Split(delimiterChars);
                        //for (int i = 0; i < words.Length; i++)
                        //{
                        if (diname.Equals("SAINS_SS_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[0].BackColor = Color.Red;
                                sains01.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[0].BackColor = Color.Yellow;
                                sains01.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[0].BackColor = Color.Green;
                                sains01.Text = Normal;
                            }else
                            {
                                tab1.Rows[1].Cells[0].BackColor = Color.Yellow;
                                sains01.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("AEON01_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[10].BackColor = Color.Red;
                                aeon01.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[10].BackColor = Color.Yellow;
                                aeon01.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[10].BackColor = Color.Green;
                                aeon01.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[10].BackColor = Color.Yellow;
                                aeon01.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("ICA01_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[11].BackColor = Color.Red;
                                ica01.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[11].BackColor = Color.Yellow;
                                ica01.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[11].BackColor = Color.Green;
                                ica01.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[11].BackColor = Color.Yellow;
                                ica01.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("SONAE01_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[9].BackColor = Color.Red;
                                sonae01.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[9].BackColor = Color.Yellow;
                                sonae01.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[9].BackColor = Color.Green;
                                sonae01.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[9].BackColor = Color.Yellow;
                                sonae01.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("SOBEYS01_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[5].BackColor = Color.Red;
                                sobeys01.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[5].BackColor = Color.Yellow;
                                sobeys01.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[5].BackColor = Color.Green;
                                sobeys01.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[5].BackColor = Color.Yellow;
                                sobeys01.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("SPARTAN01_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[7].BackColor = Color.Red;
                                spartan01.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[7].BackColor = Color.Yellow;
                                spartan01.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[7].BackColor = Color.Green;
                                spartan01.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[7].BackColor = Color.Yellow;
                                spartan01.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("MIGROS01_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[8].BackColor = Color.Red;
                                migros01.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[8].BackColor = Color.Yellow;
                                migros01.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[8].BackColor = Color.Green;
                                migros01.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[8].BackColor = Color.Yellow;
                                migros01.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("SSL03_03_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[1].BackColor = Color.Red;
                                sains02.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[1].BackColor = Color.Yellow;
                                sains02.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[1].BackColor = Color.Green;
                                sains02.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[1].BackColor = Color.Yellow;
                                sains02.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("SSL04_04_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[2].BackColor = Color.Red;
                                sains03.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[2].BackColor = Color.Yellow;
                                sains03.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[2].BackColor = Color.Green;
                                sains03.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[2].BackColor = Color.Yellow;
                                sains03.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("MADISON01_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[6].BackColor = Color.Red;
                                madison01.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[6].BackColor = Color.Yellow;
                                madison01.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[6].BackColor = Color.Green;
                                madison01.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[6].BackColor = Color.Yellow;
                                madison01.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("CVS02_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[4].BackColor = Color.Red;
                                cvs02.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[4].BackColor = Color.Yellow;
                                cvs02.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[4].BackColor = Color.Green;
                                cvs02.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[4].BackColor = Color.Yellow;
                                cvs02.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("CVS01_RUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab1.Rows[1].Cells[3].BackColor = Color.Red;
                                cvs01.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab1.Rows[1].Cells[3].BackColor = Color.Yellow;
                                cvs01.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab1.Rows[1].Cells[3].BackColor = Color.Green;
                                cvs01.Text = Normal;
                            }
                            else
                            {
                                tab1.Rows[1].Cells[3].BackColor = Color.Yellow;
                                cvs01.Text = "UnKnown";
                            }
                        }
                        
                    }

                    }


                }


            }



        
    }


     private void ColorCodingforDisk()
    {
        dir3 = ConfigurationManager.AppSettings["Ramstats"];

        string[] subdirEntries = Directory.GetDirectories(dir3);
        foreach (string d in subdirEntries)
        {

            DirectoryInfo di = new DirectoryInfo(d);

            FileInfo[] f = di.GetFiles();
            DateTime lastWrite = DateTime.MinValue;
            FileInfo lastWritenFile = null;

            String diname = di.Name.ToString();
            int count = 0;

            count = f.Length;
            if (count != 0)
            {
                foreach (FileInfo file in f)
                {
                    DateTime lastWritedelete = file.LastWriteTime;

                    TimeSpan ts = DateTime.UtcNow.Date.Subtract(file.LastWriteTime.Date);

                    if (ts.Hours > 2)
                    { file.Delete(); }
                    if ((file.LastWriteTime > lastWrite) && (file.LastWriteTime.Date == DateTime.UtcNow.Date))
                    {
                        lastWrite = file.LastWriteTime;
                        lastWritenFile = file;
                    }
                    if (lastWritenFile != null)
                    {

                        lastWritenFile = file;
                        String ff = lastWritenFile.Name.ToString();
                        String[] words = ff.Split(delimiterChars);
                        //for (int i = 0; i < words.Length; i++)
                        //{
                        //}  
                        if (diname.Equals("SAINS_SS_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[0].BackColor = Color.Red;
                                sains01_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[0].BackColor = Color.Yellow;
                                sains01_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[0].BackColor = Color.Green;
                                sains01_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[0].BackColor = Color.Yellow;
                                sains01_d.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("AEON01_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[10].BackColor = Color.Red;
                                aeon01_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[10].BackColor = Color.Yellow;
                                aeon01_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[10].BackColor = Color.Green;
                                aeon01_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[10].BackColor = Color.Yellow;
                                aeon01_d.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("ICA01_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[11].BackColor = Color.Red;
                                ica01_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[11].BackColor = Color.Yellow;
                                ica01_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[11].BackColor = Color.Green;
                                ica01_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[11].BackColor = Color.Yellow;
                                ica01_d.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("SONAE01_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[9].BackColor = Color.Red;
                                sonae01_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[9].BackColor = Color.Yellow;
                                sonae01_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[9].BackColor = Color.Green;
                                sonae01_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[9].BackColor = Color.Yellow;
                                sonae01_d.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("SOBEYS01_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[5].BackColor = Color.Red;
                                sobeys01_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[5].BackColor = Color.Yellow;
                                sobeys01_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[5].BackColor = Color.Green;
                                sobeys01_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[5].BackColor = Color.Yellow;
                                sobeys01_d.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("SPARTAN01_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[7].BackColor = Color.Red;
                                spartan01_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[7].BackColor = Color.Yellow;
                                spartan01_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[7].BackColor = Color.Green;
                                spartan01_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[7].BackColor = Color.Yellow;
                                spartan01_d.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("MIGROS01_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[8].BackColor = Color.Red;
                                migros01_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[8].BackColor = Color.Yellow;
                                migros01_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[8].BackColor = Color.Green;
                                migros01_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[8].BackColor = Color.Yellow;
                                migros01_d.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("SSL03_03_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[1].BackColor = Color.Red;
                                sains02_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[1].BackColor = Color.Yellow;
                                sains02_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[1].BackColor = Color.Green;
                                sains02_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[1].BackColor = Color.Yellow;
                                sains02_d.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("SSL04_04_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[2].BackColor = Color.Red;
                                sains03.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[2].BackColor = Color.Yellow;
                                sains03.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[2].BackColor = Color.Green;
                                sains03.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[2].BackColor = Color.Yellow;
                                sains03.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("MADISON01_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[6].BackColor = Color.Red;
                                madison01_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[6].BackColor = Color.Yellow;
                                madison01_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[6].BackColor = Color.Green;
                                madison01_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[6].BackColor = Color.Yellow;
                                madison01_d.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("CVS02_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[4].BackColor = Color.Red;
                                cvs02_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[4].BackColor = Color.Yellow;
                                cvs02_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[4].BackColor = Color.Green;
                                cvs02_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[4].BackColor = Color.Yellow;
                                cvs02_d.Text = "UnKnown";
                            }
                        }
                        if (diname.Equals("CVS01_DUS"))
                        {
                            if (ff.Contains(Critical))
                            {
                                tab2.Rows[1].Cells[3].BackColor = Color.Red;
                                cvs01_d.Text = Critical;
                            }
                            else if (ff.Contains(Warning))
                            {
                                tab2.Rows[1].Cells[3].BackColor = Color.Yellow;
                                cvs01_d.Text = Warning;
                            }
                            else if (ff.Contains(Normal))
                            {
                                tab2.Rows[1].Cells[3].BackColor = Color.Green;
                                cvs01_d.Text = Normal;
                            }
                            else
                            {
                                tab2.Rows[1].Cells[3].BackColor = Color.Yellow;
                                cvs01_d.Text = "UnKnown";
                            }
                        }

                    }


                }


            }



        }
    }
}





