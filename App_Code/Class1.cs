using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace nsaboutme
{
    //**********************************1
   public partial class clscon
    {
        protected SqlConnection con=new SqlConnection();
     public   clscon()
        {
            con.ConnectionString=ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }
    }





    //**********************************2
   public interface intfavprf
    {
        Int32 p_favprfcod
        {
            get;
            set;
        }

        Int32 p_favprfregcod
        {
            get;
            set;
        }

        Int32 p_favprfprfcod
        {
            get;
            set;
        }
    }
   public class clsfavprfprp : intfavprf
   {
       private Int32 favprfcod, favprfregcod, favprfprfcod;
       public int p_favprfcod
       {
           get
           {
               return favprfcod;
           }
           set
           {
               favprfcod = value;
           }
       }

       public int p_favprfregcod
       {
           get
           {
               return favprfregcod;
           }
           set
           {
               favprfregcod = value;
           }
       }

       public int p_favprfprfcod
       {
           get
           {
               return favprfprfcod;
           }
           set
           {
               favprfprfcod = value;
           }
       }
   }
   public class clsfavprf : clscon
   {
       public void Save_Rec(clsfavprfprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("insfavprf",con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@favprfregcod", SqlDbType.Int).Value = p.p_favprfregcod;
           cmd.Parameters.Add("@favprfprfcod", SqlDbType.Int).Value = p.p_favprfprfcod;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       public void Update_Rec(clsfavprfprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("updfavprf", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@favprfcod", SqlDbType.Int).Value = p.p_favprfcod;
           cmd.Parameters.Add("@favprfregcod", SqlDbType.Int).Value = p.p_favprfregcod;
           cmd.Parameters.Add("@favprfprfcod", SqlDbType.Int).Value = p.p_favprfprfcod;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       public void Delete_Rec(clsfavprfprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("delfavprf", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@favprfcod", SqlDbType.Int).Value = p.p_favprfcod;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       List<clsfavprfprp> Find_Rec(Int32 favprfcod)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("fndfavprf", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@favprfregcod", SqlDbType.Int).Value = favprfcod;
           SqlDataReader dr;
         dr=  cmd.ExecuteReader();
           List<clsfavprfprp> obj = new List<clsfavprfprp>();
           while (dr.Read())
           {
               clsfavprfprp k = new clsfavprfprp();
               k.p_favprfcod = Convert.ToInt32(dr[0]);
               k.p_favprfregcod=Convert.ToInt32(dr[1]);
               k.p_favprfprfcod = Convert.ToInt32(dr[2]);
               obj.Add(k);
           }
           cmd.Dispose();
           con.Close();
           dr.Close();
           return obj;
       }
       List<clsfavprfprp> Disp_Rec()
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("dspfavprf", con);
           cmd.CommandType = CommandType.StoredProcedure;
        
           SqlDataReader dr;
      dr=     cmd.ExecuteReader();
           List<clsfavprfprp> obj = new List<clsfavprfprp>();
           if(dr.HasRows)
           {
               dr.Read();
               clsfavprfprp k = new clsfavprfprp();
               k.p_favprfcod = Convert.ToInt32(dr[0]);
               k.p_favprfregcod = Convert.ToInt32(dr[1]);
               k.p_favprfprfcod = Convert.ToInt32(dr[2]);
               obj.Add(k);
           }
           cmd.Dispose();
           con.Close();
           dr.Close();
           return obj;
       }
   }





    //***********************************3
   public interface intprf
   {
       String p_prfbckpic
       {
           get;
           set;
       }
       String p_prfpic
       {
           get;
           set;
       }
       Int32 p_prfcod
       {
           get;
           set;
       }

       Int32 p_prfregcod
       {
           get;
           set;
       }

       String p_prffstnam
       {
           get;
           set;
       }

       String p_prflstnam
       {
           get;
           set;
       }
       String p_prfhedlin
       {
           get;
           set;
       }

       String p_prfbio
       {
           get;
           set;
       }
       Char p_prfalleml
       {
           get;
           set;
       }
   }
   public class clsprfprp :intprf
   {
       private Int32 prfcod, prfregcod;
       private String prflstnam, prffstnam, prfhedlin, prfbio,prfbckpic,prfpic;
       private Char prfalleml;
       public String p_prfbckpic
       {
           get
           {
               return prfbckpic;
           }
           set
           {
               prfbckpic = value;
           }
       }
       public String p_prfpic
       {
           get
           {
               return prfpic;
           }
           set
           {
               prfpic = value;
           }
       }
       public int p_prfcod
       {
           get
           {
               return prfcod;
           }
           set
           {
               prfcod = value;
           }
       }

       public int p_prfregcod
       {
           get
           {
               return prfregcod;
           }
           set
           {
               prfregcod = value;
           }
       }

       public string p_prffstnam
       {
           get
           {
               return prffstnam;
           }
           set
           {
               prffstnam = value;
           }
       }

       public string p_prflstnam
       {
           get
           {
               return prflstnam;
           }
           set
           {
               prflstnam = value;
           }
       }

       public string p_prfhedlin
       {
           get
           {
               return prfhedlin;
           }
           set
           {
               prfhedlin = value;
           }
       }

       public string p_prfbio
       {
           get
           {
               return prfbio;
           }
           set
           {
               prfbio = value;
           }
       }

       public char p_prfalleml
       {
           get
           {
               return prfalleml;
           }
           set
           {
               prfalleml = value;
           }
       }
   }
   public class clsprf : clscon
   {
       public DataSet srcprf(String srcstr, Int32 regcod)
       {
           SqlDataAdapter adp = new SqlDataAdapter("srcprf", con);
           adp.SelectCommand.CommandType = CommandType.StoredProcedure;
           adp.SelectCommand.Parameters.Add("@srcstr", SqlDbType.VarChar, 50).Value = srcstr;
           adp.SelectCommand.Parameters.Add("@regcod", SqlDbType.Int).Value = regcod;
           DataSet ds = new DataSet();
           adp.Fill(ds);
           return ds;
       }
       public DataSet favprf(Int32 regcod)
       {
           SqlDataAdapter adp = new SqlDataAdapter("dspfavprf", con);
           adp.SelectCommand.CommandType = CommandType.StoredProcedure;
           adp.SelectCommand.Parameters.Add("@regcod", SqlDbType.Int).Value = regcod;
           DataSet ds = new DataSet();
           adp.Fill(ds);
           return ds;
       }
       public void Save_Rec(clsprfprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("insprf", con);
           cmd.CommandType = CommandType.StoredProcedure;
           //cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = p.p_prfcod;
           cmd.Parameters.Add("@prfregcod", SqlDbType.Int).Value = p.p_prfregcod;
           cmd.Parameters.Add("@prffstnam", SqlDbType.VarChar,50).Value = p.p_prffstnam;
           cmd.Parameters.Add("@prfhedlin", SqlDbType.VarChar, 200).Value = p.p_prfhedlin;
           cmd.Parameters.Add("@prfbio", SqlDbType.VarChar, 2500).Value = p.p_prfbio;
           cmd.Parameters.Add("@prfalleml", SqlDbType.Char,1).Value = p.p_prfalleml ;
           cmd.Parameters.Add("@prflstnam", SqlDbType.VarChar, 50).Value = p.p_prflstnam;
           cmd.Parameters.Add("@prfbckpic", SqlDbType.VarChar, 200).Value = p.p_prfbckpic;
           cmd.Parameters.Add("@prfpic", SqlDbType.VarChar, 50).Value = p.p_prfpic;

           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       public void Update_Rec(clsprfprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("updprf", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = p.p_prfcod;
           cmd.Parameters.Add("@prfregcod", SqlDbType.Int).Value = p.p_prfregcod;
           cmd.Parameters.Add("@prffstnam", SqlDbType.VarChar, 50).Value = p.p_prffstnam;
           cmd.Parameters.Add("@prfhedlin", SqlDbType.VarChar, 200).Value = p.p_prfhedlin;
           cmd.Parameters.Add("@prfbio", SqlDbType.VarChar, 2500).Value = p.p_prfbio;
           cmd.Parameters.Add("@prfalleml", SqlDbType.Char, 1).Value = p.p_prfalleml;
           cmd.Parameters.Add("@prflstnam", SqlDbType.VarChar, 50).Value = p.p_prflstnam;
           cmd.Parameters.Add("@prfbckpic", SqlDbType.VarChar, 200).Value = p.p_prfbckpic;
           cmd.Parameters.Add("@prfpic", SqlDbType.VarChar, 50).Value = p.p_prfpic; 
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       public void Delete_Rec(clsprfprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("delprf", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@prfcod", SqlDbType.Int).Value = p.p_prfcod;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
      public List<clsprfprp> Find_Rec(Int32 prfcod)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("fndprf", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@favprfregcod", SqlDbType.Int).Value = prfcod;
           SqlDataReader dr;
           dr = cmd.ExecuteReader();
           List<clsprfprp> obj = new List<clsprfprp>();
           while (dr.Read())
           {
               clsprfprp k = new clsprfprp();
               k.p_prfcod = Convert.ToInt32(dr[0]);
               k.p_prfregcod = Convert.ToInt32(dr[1]);
               k.p_prffstnam = dr[2].ToString();
               k.p_prflstnam = dr[3].ToString();
               k.p_prfhedlin = dr[4].ToString();
               k.p_prfbio = dr[5].ToString();
               k.p_prfalleml = Convert.ToChar(dr[6]);
               obj.Add(k);
           }
           cmd.Dispose();
           con.Close();
           dr.Close();
           return obj;
       }
       public List<clsprfprp> Disp_Rec(Int32 regcod)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("dspprf", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@regcod", SqlDbType.Int).Value = regcod;
           SqlDataReader dr;
           dr = cmd.ExecuteReader();
           List<clsprfprp> obj = new List<clsprfprp>();
           if (dr.HasRows)
           {
               dr.Read();
               clsprfprp k = new clsprfprp();
               k.p_prfcod = Convert.ToInt32(dr[0]);
               k.p_prfregcod = Convert.ToInt32(dr[1]);
               k.p_prffstnam = dr[2].ToString();
               k.p_prflstnam = dr[3].ToString();
               k.p_prfhedlin = dr[4].ToString();
               k.p_prfbio = dr[5].ToString();
               k.p_prfalleml = Convert.ToChar(dr[6]);
               k.p_prfbckpic = dr[7].ToString();
               k.p_prfpic = dr[8].ToString();
               obj.Add(k);
           }
           cmd.Dispose();
           con.Close();
           dr.Close();
           return obj;
       }
   }





    //************************************4
   public interface intreg
   {
       Int32 p_regcod
       {
           get;
           set;
       }
       String p_regnam
       {
           get;
           set;
       }
       String p_regeml
       {
           get;
           set;
       }
       String p_regpas
       {
           get;
           set;
       }

       Char p_regsts
       {
           get;
           set;
       }
   }
   public class clsregprp : intreg
   {
       String regnam, regpas, regeml;
       Int32 regcod;
       Char regsts;
       public int p_regcod
       {
           get
           {
               return regcod;
           }
           set
           {
               regcod = value;
           }
       }

       public string p_regnam
       {
           get
           {
               return regnam;
           }
           set
           {
               regnam = value;
           }
       }

       public string p_regeml
       {
           get
           {
               return regeml;
           }
           set
           {
               regeml = value;
           }
       }

       public string p_regpas
       {
           get
           {
               return regpas;
           }
           set
           {
               regpas = value;
           }
       }

       public char p_regsts
       {
           get
           {
               return regsts; 
           }
           set
           {
               regsts = value;
           }
       }
   }
   public class clsreg : clscon
   {
       public Int32 logincheck(String usreml, String usrpwd, out char usrrol)
       {
           if (con.State == ConnectionState.Closed)
               con.Open();
           SqlCommand cmd = new SqlCommand("logincheck", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 50).Value = usreml;
           cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 50).Value = usrpwd;
           cmd.Parameters.Add("@usrcod", SqlDbType.Int).Direction = ParameterDirection.Output;
           cmd.Parameters.Add("@usrrol", SqlDbType.Char, 1).Direction = ParameterDirection.Output;
           cmd.ExecuteNonQuery();
           usrrol = Convert.ToChar(cmd.Parameters["@usrrol"].Value);
           Int32 a = Convert.ToInt32(cmd.Parameters["@usrcod"].Value);
           cmd.Dispose();
           con.Close();
           return a;
       }
       public void Save_Rec(clsregprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("insreg",con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@regnam", SqlDbType.VarChar, 50).Value = p.p_regnam;
           cmd.Parameters.Add("@regeml", SqlDbType.VarChar, 50).Value = p.p_regeml;
           cmd.Parameters.Add("@regpwd", SqlDbType.VarChar, 50).Value = p.p_regpas;
           cmd.Parameters.Add("@regsts", SqlDbType.Char, 1).Value = p.p_regsts;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       public void Update_Rec(clsregprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("updreg", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@regcod", SqlDbType.Int).Value = p.p_regcod;
           cmd.Parameters.Add("@regnam", SqlDbType.VarChar, 50).Value = p.p_regnam;
           cmd.Parameters.Add("@regeml", SqlDbType.VarChar, 50).Value = p.p_regeml;
           cmd.Parameters.Add("@regpas", SqlDbType.VarChar, 50).Value = p.p_regpas;
           cmd.Parameters.Add("@regsts", SqlDbType.Char, 1).Value = p.p_regsts;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       public void Delete_Rec(clsregprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("delreg", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@regcod", SqlDbType.Int).Value = p.p_regcod;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       public List<clsregprp> Find_Rec(Int32 regcod)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("fndreg", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@regcod", SqlDbType.Int).Value = regcod;
           SqlDataReader dr;
           dr = cmd.ExecuteReader();
           List<clsregprp> obj = new List<clsregprp>();
           while (dr.Read())
           {
               clsregprp k = new clsregprp();
               k.p_regcod = Convert.ToInt32(dr[0]);
               k.p_regnam = dr[1].ToString();
               k.p_regeml = dr[2].ToString();
               k.p_regpas = dr[3].ToString();
               k.p_regsts = Convert.ToChar(dr[4]);
           }
           cmd.Dispose();
           con.Close();
           dr.Close();
           return obj;
          
       }
       public List<clsregprp> Disp_Rec(Int32 regcod)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("dspreg", con);
           cmd.CommandType = CommandType.StoredProcedure;
          // cmd.Parameters.Add("@regcod", SqlDbType.Int).Value = regcod;
           SqlDataReader dr;
           dr = cmd.ExecuteReader();
           List<clsregprp> obj = new List<clsregprp>();
           if(dr.HasRows)
           {
               dr.Read();
               clsregprp k = new clsregprp();
               k.p_regcod = Convert.ToInt32(dr[0]);
               k.p_regnam = dr[1].ToString();
               k.p_regeml = dr[2].ToString();
               k.p_regpas = dr[3].ToString();
               k.p_regsts = Convert.ToChar(dr[4]);
           }
           cmd.Dispose();
           con.Close();
           dr.Close();
           return obj;

       }

   }
    
   



    //************************************5
   public interface intser
   {
       Int32 p_sercod
       {
           get;
           set;
       }
       String p_sernam
       {
           get;
           set;
       }
       String p_serlog
       {
           get;
           set;
       }
       String p_serpic
       {
           get;
           set;
       }
       String p_serbasurl
       {
           get;
           set;
       }
   }
   public class clserprp : intser
   {
       String sernam, serlog, serpic,serbasurl;
       Int32 sercod;
       public int p_sercod
       {
           get
           {
               return sercod;
           }
           set
           {
               sercod=value;
           }
       }

       public string p_sernam
       {
           get
           {
               return sernam;
           }
           set
           {
               sernam=value;
           }
       }

       public string p_serlog
       {
           get
           {
               return serlog;
           }
           set
           {
               serlog=value;
           }
       }

       public string p_serpic
       {
           get
           {
               return serpic;
           }
           set
           {
               serpic=value;
           }
       }

       public string p_serbasurl
       {
           get
           {
               return serbasurl;
           }
           set
           {
               serbasurl=value;
           }
       }
   }
   public class clsser : clscon
   {
       public Int32 Save_Rec(clserprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("insser",con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@sernam", SqlDbType.VarChar, 100).Value = p.p_sernam;
           cmd.Parameters.Add("@serlog", SqlDbType.VarChar, 100).Value = p.p_serlog;
           cmd.Parameters.Add("@serpic", SqlDbType.VarChar, 100).Value = p.p_serpic;
           cmd.Parameters.Add("@serbasurl", SqlDbType.VarChar, 100).Value = p.p_serbasurl;
           cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
           cmd.ExecuteNonQuery();
           Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
           cmd.Dispose();
           con.Close();
           return a;
       }
       public void Update_Rec(clserprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("updser", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@sercod", SqlDbType.Int).Value = p.p_sercod;
           cmd.Parameters.Add("@sernam", SqlDbType.VarChar, 100).Value = p.p_sernam;
           cmd.Parameters.Add("@serlog", SqlDbType.VarChar, 100).Value = p.p_serlog;
           cmd.Parameters.Add("@serlog", SqlDbType.VarChar, 100).Value = p.p_serpic;
           cmd.Parameters.Add("@serbasurl", SqlDbType.VarChar, 100).Value = p.p_serbasurl;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();

       }
       public void Delete_Rec(clserprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("delser", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@sercod", SqlDbType.Int).Value = p.p_sercod;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();

       }
       public List<clserprp> Disp_Rec()
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("dspser", con);
           cmd.CommandType = CommandType.StoredProcedure;
           SqlDataReader dr = cmd.ExecuteReader();
           List<clserprp> obj = new List<clserprp>();
           while (dr.Read())
           {
               clserprp k = new clserprp();
               k.p_sercod = Convert.ToInt32(dr[0]);
               k.p_sernam = dr[1].ToString();
               k.p_serlog = dr[2].ToString();
               k.p_serpic = dr[3].ToString();
               k.p_serbasurl = dr[4].ToString();
               obj.Add(k);
           }
           cmd.Dispose();
           con.Close();
           dr.Close();
           return obj;
       }
       public List<clserprp> Find_Rec(Int32 sercod)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("fndser", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@sercod", SqlDbType.Int).Value = sercod;
           SqlDataReader dr = cmd.ExecuteReader();
           List<clserprp> obj = new List<clserprp>();
           if(dr.HasRows)
           {
               dr.Read();
               clserprp k = new clserprp();
               k.p_sercod = Convert.ToInt32(dr[0]);
               k.p_sernam = dr[1].ToString();
               k.p_serlog = dr[2].ToString();
               k.p_serpic = dr[3].ToString();
               k.p_serbasurl = dr[4].ToString();
               obj.Add(k);
           }
           cmd.Dispose();
           con.Close();
           dr.Close();
           return obj;
       }
   }





    //**************************************6
   interface intsit
   {
      
       Int32 p_sitcod
       {
           get;
           set;
       }
       Int32 p_sitregcod
       {
           get;
           set;
       }
       String p_siturl
       {
           get;
           set;
       }
       Char p_sitsersts
       {
           get;
           set;
       }
       Int32 p_sitsercod
       {
           get;
           set;
       }


   }
   public class clssitprp : intsit
   {
       Int32 sitcod, sitregcod, sitsercod;
       String siturl;
       Char sitsersts;
       public int p_sitcod
       {
           get
           {
               return sitcod;
           }
           set
           {
               sitcod = value;
           }
       }

       public int p_sitregcod
       {
           get
           {
               return sitregcod;
           }
           set
           {
               sitregcod = value;
           }
       }

       public string p_siturl
       {
           get
           {
               return siturl;
           }
           set
           {
               siturl = value;
           }
       }

       public char p_sitsersts
       {
           get
           {
               return sitsersts;
           }
           set
           {
               value = sitsersts;
           }
       }

       public int p_sitsercod
       {
           get
           {
               return sitsercod;
           }
           set
           {
               sitsercod = value;
           }
       }
   }
   public class clssit : clscon
   {
       public void Save_Rec(clssitprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("inssit", con);
           cmd.CommandType = CommandType.StoredProcedure;
      //     cmd.Parameters.Add("@sitcod", SqlDbType.Int).Value = p.p_sitcod;
           cmd.Parameters.Add("@sitregcod", SqlDbType.Int).Value = p.p_sitregcod;
           cmd.Parameters.Add("@siturl", SqlDbType.VarChar, 100).Value = p.p_siturl;
           cmd.Parameters.Add("@sitsersts", SqlDbType.Char, 1).Value = p.p_sitsersts;
           cmd.Parameters.Add("@sitsercod", SqlDbType.Int).Value = p.p_sitsercod;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
          
       }
       public void Update_Rec(clssitprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("updsit", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@sitcod", SqlDbType.Int).Value = p.p_sitcod;
           cmd.Parameters.Add("@sitregcod", SqlDbType.Int).Value = p.p_sitregcod;
           cmd.Parameters.Add("@siturl", SqlDbType.VarChar, 100).Value = p.p_siturl;
           cmd.Parameters.Add("@sitsts", SqlDbType.Char, 1).Value = p.p_sitsersts;
           cmd.Parameters.Add("@sitsercod", SqlDbType.Int).Value = p.p_sitsercod;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       public void Delete_Rec(clssitprp p)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("insit", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@sitcod", SqlDbType.Int).Value = p.p_sitcod;
           cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
       }
       public List<clssitprp> Disp_Rec(Int32 regcod)
       {
           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("dspsit", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@regcod", SqlDbType.Int).Value = regcod;
           SqlDataReader dr = cmd.ExecuteReader();
           List<clssitprp> obj = new List<clssitprp>();
           while (dr.Read())
           {
               clssitprp k = new clssitprp();
               k.p_sitcod = Convert.ToInt32(dr[0]);
               k.p_sitregcod=Convert.ToInt32(dr[1]);
               k.p_siturl = dr[2].ToString();
               k.p_sitsersts=Convert.ToChar(dr[3]);
               k.p_sitsercod = Convert.ToInt32(dr[4]);
               obj.Add(k);
           }
           cmd.Dispose();
           con.Close();
           dr.Close();
           return obj;
           
       }
       public List<clssitprp> Find_Rec(Int32 sitcod)
       {

           if (con.State == ConnectionState.Closed)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand("fndsit", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("@sitcod", SqlDbType.Int).Value = sitcod;
           SqlDataReader dr = cmd.ExecuteReader();
           List<clssitprp> obj = new List<clssitprp>();
           if(dr.HasRows)
           {
               dr.Read();
               clssitprp k = new clssitprp();
               k.p_sitcod = Convert.ToInt32(dr[0]);
               k.p_sitregcod = Convert.ToInt32(dr[1]);
               k.p_siturl = dr[2].ToString();
               k.p_sitsersts = Convert.ToChar(dr[3]);
               k.p_sitsercod = Convert.ToInt32(dr[4]);
               obj.Add(k);
           }
           cmd.Dispose();
           con.Close();
           dr.Close();
           return obj;
           
       }
   }
    



}