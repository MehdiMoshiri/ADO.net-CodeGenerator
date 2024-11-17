using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeClassGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_copy1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_output_1.Text != string.Empty)
                    Clipboard.SetText(txt_output_1.Text.Trim());
            }
            catch { }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_output_1.ResetText();
            txt_nameClass.ResetText();
            txt_nametable.ResetText();
        }

        string _ConnectionString = "";
        private string classMake(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);

            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - class \n ";

                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                    if (type != "false")
                    {
                        if (type == "DateTime")
                            Output = Output + "public " + type + " " + Arry[index] + " =  DateTime.Now; // " + (index + 1) + "   \n";
                        else
                            Output = Output + "public " + type + " " + Arry[index] + " = " + GetValueDatatype(type) + "; // " + (index + 1) + "   \n";
                    }
                }
            }
            return Output;
        }

        private string classMakeApi(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);

            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - class Api \n ";

                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                    if (type != "false")
                    {
                        if (type == "datetime")
                            Output = Output + "public " + type + " " + Arry[index] + " { get; set; } // " + (index + 1) + "   \n";
                        else
                            Output = Output + "public " + type + " " + Arry[index] + " { get; set; } // " + (index + 1) + "   \n";
                    }
                }
            }
            return Output;
        }

        private string select_title(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);


            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - dataset \n ";

                //if (che_addID.Checked)
                //{
                //    Output = Output + "obj" + ClassName + ".id = objDataSet." + TableName + "[0].id; // 1 \n";
                //    index = 2;
                //}

                //foreach (string s in List)
                //{
                //    if (s.IndexOf(']') != -1)
                //    {
                //        string NS = s.Substring(0, s.IndexOf(']'));
                //        string type = GetDatatype(s);
                //        if (type != "false")
                //        {
                //            Output = Output + "obj" + ClassName + "." + NS + " = objDataSet." + TableName + "[0]." + NS + "; // " + index + "  \n";
                //            index++;
                //        }
                //    }
                //}


                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                    if (type == "double")
                    {
                        Output = Output + "obj" + ClassName + "." + Convert.ToString(Arry[index]) + " =  Convert.ToDouble(objDataSet." + TableName + "[0]." + Convert.ToString(Arry[index]) + "); // " + (index + 1) + "  \n";
                    }
                    else if (type != "false")
                    {
                        Output = Output + "obj" + ClassName + "." + Convert.ToString(Arry[index]) + " = objDataSet." + TableName + "[0]." + Convert.ToString(Arry[index]) + "; // " + (index + 1) + "  \n";
                    }

                }
            }

            return Output;
        }

        private string GetValueDatatype(string type)
        {
            if (type == "int") return "0";
            else if (type == "double") return "0";
            else if (type == "string") return " \" \" ";
            else if (type == "bool") return "false";
            else if (type == "long") return "0";
            else return "0";
        }

        private string GetDatatype(string s)
        {
            //if (s.IndexOf(", int") != -1) return "int";
            //else if (s.IndexOf(", real") != -1) return "double";
            //else if (s.IndexOf(", nvarchar") != -1) return "string";
            //else if (s.IndexOf(", bit") != -1) return "bool";
            //else if (s.IndexOf(", bigint") != -1) return "long";
            //else return "false";

            if (s.Contains("int") && !s.Contains("big")) return "int";
            else if (s.Contains("real")) return "double";
            else if (s.Contains("decimal")) return "double";
            else if (s.Contains("nvarchar")) return "string";
            else if (s.Contains("bit")) return "bool";
            else if (s.Contains("bigint")) return "long";
            else if (s.Contains("char")) return "string";
            else if (s.Contains("ntext")) return "string";
            else if (s.Contains("text")) return "string";
            else if (s.Contains("datetime")) return "DateTime";
            else if (s.Contains("float")) return "double";

            else return "false";
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            ConnectionLoad();
        }

        private void ConnectionLoad()
        {
            string Server = txt_server.Text.Trim();
            string DataBase = com_db.Text.Trim();
            string User = txt_user.Text.Trim();
            string Pass = txt_password.Text.Trim();
            if (Server != string.Empty)
            {
                if (DataBase != string.Empty)
                {
                    if (User != string.Empty)
                    {
                        if (Pass != string.Empty)
                        {
                            string ConnectionString = " Data Source=" + Server + ";Initial Catalog= " + DataBase + ";Persist Security Info=True;User ID=" + User + ";Password=" + Pass + " ";

                            if (rad_b.Checked)
                                LoadTablesAll(ConnectionString);
                            else if (rad_views.Checked)
                                LoadTablesView(ConnectionString);
                            else if (rad_t.Checked)
                                LoadTablesTables(ConnectionString);

                        }
                    }
                }
            }
        }

        private void LoadTablesAll(string connectionString)
        {
            string TestCode = " SELECT A.name , A.xtype FROM sysobjects A  WHERE A.xtype = 'U' or A.xtype = 'V' ";
            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = new SqlCommand();
            objDataAdapter.SelectCommand.Connection = connection1;
            objDataAdapter.SelectCommand.CommandText = TestCode;
            objDataAdapter.SelectCommand.CommandType = CommandType.Text;

            list_tables.Items.Clear();

            //   DataSet1 objDataSet = new DataSet1();
            DataTable dt = new DataTable();
            try
            {
                objDataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    list_tables.Items.Add(dr.ItemArray[0]);
                }

                list_tables.Sorted = true;
            }
            catch (Exception Ex)
            {

            }

            objDataAdapter = null;
            connection1 = null;
        }

        private void LoadTablesView(string connectionString)
        {
            string TestCode = " SELECT A.name , A.xtype FROM sysobjects A  WHERE   A.xtype = 'V' ";
            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = new SqlCommand();
            objDataAdapter.SelectCommand.Connection = connection1;
            objDataAdapter.SelectCommand.CommandText = TestCode;
            objDataAdapter.SelectCommand.CommandType = CommandType.Text;

            list_tables.Items.Clear();

            //   DataSet1 objDataSet = new DataSet1();
            DataTable dt = new DataTable();
            try
            {
                objDataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    list_tables.Items.Add(dr.ItemArray[0]);
                }

                list_tables.Sorted = true;
            }
            catch (Exception Ex)
            {

            }

            objDataAdapter = null;
            connection1 = null;
        }

        private void LoadTablesTables(string connectionString)
        {
            string TestCode = " SELECT A.name , A.xtype FROM sysobjects A  WHERE A.xtype = 'U'  ";
            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = new SqlCommand();
            objDataAdapter.SelectCommand.Connection = connection1;
            objDataAdapter.SelectCommand.CommandText = TestCode;
            objDataAdapter.SelectCommand.CommandType = CommandType.Text;

            list_tables.Items.Clear();

            //   DataSet1 objDataSet = new DataSet1();
            DataTable dt = new DataTable();
            try
            {
                objDataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    list_tables.Items.Add(dr.ItemArray[0]);
                }

                list_tables.Sorted = true;
            }
            catch (Exception Ex)
            {

            }

            objDataAdapter = null;
            connection1 = null;
        }

        private void LoadDataBase()
        {
            string Server = txt_server.Text.Trim();
            string DataBase = "master";
            string User = txt_user.Text.Trim();
            string Pass = txt_password.Text.Trim();
            if (Server != string.Empty)
            {
                if (DataBase != string.Empty)
                {
                    if (User != string.Empty)
                    {
                        if (Pass != string.Empty)
                        {
                            string ConnectionString = " Data Source=" + Server + ";Initial Catalog= " + DataBase + ";Persist Security Info=True;User ID=" + User + ";Password=" + Pass + " ";

                            string TestCode = " SELECT DB_NAME(database_id) AS [Database] FROM sys.databases "
                                  + " where DB_NAME(database_id) not in ('master', 'tempdb', 'model', 'msdb') ";
                            SqlConnection connection1 = new SqlConnection(ConnectionString);
                            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
                            objDataAdapter.SelectCommand = new SqlCommand();
                            objDataAdapter.SelectCommand.Connection = connection1;
                            objDataAdapter.SelectCommand.CommandText = TestCode;
                            objDataAdapter.SelectCommand.CommandType = CommandType.Text;

                            com_db.Items.Clear();

                            //   DataSet1 objDataSet = new DataSet1();
                            DataTable dt = new DataTable();
                            try
                            {
                                objDataAdapter.Fill(dt);
                                foreach (DataRow dr in dt.Rows)
                                {
                                    com_db.Items.Add(dr.ItemArray[0]);
                                }

                                com_db.Sorted = true;
                            }
                            catch (Exception Ex)
                            {

                            }

                            objDataAdapter = null;
                            connection1 = null;
                        }
                    }
                }
            }
        }

        private ArrayList GetColoumnNames(string connectionString, string TablesName, out ArrayList DataTypeArry)
        {
            ArrayList Arr = new ArrayList();
            ArrayList DBV = new ArrayList();
            string DataBase = com_db.Text.Trim();
            string TestCode = " SELECT COLUMN_NAME AS 'ret' ,DATA_TYPE as 'data' FROM " + DataBase + ".INFORMATION_SCHEMA.COLUMNS  WHERE TABLE_NAME = N'" + TablesName + "'  ";
            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = new SqlCommand();
            objDataAdapter.SelectCommand.Connection = connection1;
            objDataAdapter.SelectCommand.CommandText = TestCode;
            objDataAdapter.SelectCommand.CommandType = CommandType.Text;

            //   DataSet1 objDataSet = new DataSet1();
            DataTable dt = new DataTable();

            try
            {
                objDataAdapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Arr.Add(dr.ItemArray[0]);
                    DBV.Add(dr.ItemArray[1]);
                }

                list_tables.Sorted = true;
            }
            catch (Exception Ex)
            {

            }

            objDataAdapter = null;
            connection1 = null;
            DataTypeArry = DBV;
            return Arr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nameClass.Text != string.Empty)
                    Clipboard.SetText(txt_nameClass.Text.Trim());
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nametable.Text != string.Empty)
                    Clipboard.SetText(txt_nametable.Text.Trim());
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = " Auto Code Generator Mehdi Moshiri 2016-2024 - v2.16 2024-01-11 ";
            //  v1.2 95-04-29  Iran
            //  v1.3 95-05-23 
            //  v1.4 96-03-27 
            //  v2.4 96-04-10
            //  v2.5 96-10-23 - 1/13/2018
            //  v2.6 97-06-09 - 8/31/2018
            //  v2.9 97-08-03 - 10/25/2018
            //  v2.10 98-02-26  5/16/2019
            //  v2.11 98-05-22  8/12/2019 
            //  v2.12 99-10-14  1/3/2021 
            //  v2.14 99-11-27
            //  v2.15 1402-08-03  10/25/2023  Netherlands 
            //  v2.16 1402-10-20  2024-01-11  Netherlands 

            LoadSetting();
            LoadDataBase();
        }

        string _Server = "", _db = "", _username = "", _passw = "";

        private void LoadSetting()
        {
            string FileName = "opt.txt";
            string Server = "", db = "", username = "", passw = "";
            string error = "";
            FMS fs = new FMS();
            if (fs.ReadFromFile(FileName, "serverName", out Server, out error, "."))
            {
                if (fs.ReadFromFile(FileName, "dbName", out db, out error, "RoseDB"))
                {
                    if (fs.ReadFromFile(FileName, "username", out username, out error, "sa"))
                    {
                        if (fs.ReadFromFile(FileName, "password", out passw, out error, "15421"))
                        {
                            _Server = Server;
                            _db = db;
                            _username = username;
                            _passw = passw;

                            txt_server.Text = _Server.Trim();
                            com_db.Text = _db.Trim();
                            txt_user.Text = _username.Trim();
                            txt_password.Text = _passw.Trim();

                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Output = " ";
            Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - insert i Function \n ";
            Output = Output + " public Boolean InsertToDB_ReturnID(string TextInsert, out int ID) \n ";
            Output = Output + "{  \n ";
            Output = Output + "int intOut = 0; \n ";
            Output = Output + "bool Output = false; \n ";
            Output = Output + "SqlConnection connection1 = new SqlConnection(aa_Items.DataBaseConnectionString); \n ";
            Output = Output + "SqlDataAdapter objDataAdapter = new SqlDataAdapter(); \n ";
            Output = Output + "objDataAdapter.SelectCommand = new SqlCommand(); \n ";
            Output = Output + "objDataAdapter.SelectCommand.Connection = connection1; \n ";
            Output = Output + "objDataAdapter.SelectCommand.CommandText = TextInsert; \n ";
            Output = Output + "objDataAdapter.SelectCommand.CommandType = CommandType.Text; \n ";
            Output = Output + "DataSet1 objDataSet = new DataSet1(); \n ";
            Output = Output + "try \n ";
            Output = Output + "{ \n ";
            Output = Output + "objDataSet.t_result_int.Clear(); \n ";
            Output = Output + "objDataAdapter.Fill(objDataSet.t_result_int); \n ";
            Output = Output + "intOut = objDataSet.t_result_int[0].ret; \n ";
            Output = Output + "if (intOut != 0) Output = true; \n ";
            Output = Output + "else Output = false; \n ";
            Output = Output + "} \n ";
            Output = Output + "catch { } \n ";
            Output = Output + "objDataAdapter = null; \n ";
            Output = Output + "connection1 = null; \n ";
            Output = Output + "ID = intOut; \n ";
            Output = Output + "return Output; \n ";
            Output = Output + "} \n ";
            txt_output_1.Text = Output;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string Output = " ";
            Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - insert i Function \n ";
            Output = Output + "public Boolean ExecuteNonQuery_Function_ret_Boolean(string Text) \n ";
            Output = Output + "{ \n ";
            Output = Output + "    int intOut = 0; \n ";
            Output = Output + "    bool Output = false; \n ";
            Output = Output + "    SqlConnection connection1 = new SqlConnection(aa_Items.DataBaseConnectionString); \n ";
            Output = Output + "    SqlDataAdapter objDataAdapter = new SqlDataAdapter(); \n ";
            Output = Output + "    objDataAdapter.SelectCommand = new SqlCommand(); \n ";
            Output = Output + "    objDataAdapter.SelectCommand.Connection = connection1; \n ";
            Output = Output + "    objDataAdapter.SelectCommand.CommandText = Text; \n ";
            Output = Output + "    objDataAdapter.SelectCommand.CommandType = CommandType.Text; \n ";
            Output = Output + " \n ";
            Output = Output + "    DataSet1 objDataSet = new DataSet1(); \n ";
            Output = Output + "    try \n ";
            Output = Output + "    { \n ";
            Output = Output + "        objDataSet.t_result_int.Clear(); \n ";
            Output = Output + "        objDataAdapter.Fill(objDataSet.t_result_int); \n ";
            Output = Output + "        intOut = objDataSet.t_result_int[0].ret; \n ";
            Output = Output + "        if (intOut == 1) Output = true; \n ";
            Output = Output + "    } \n ";
            Output = Output + "    catch { } \n ";
            Output = Output + " \n ";
            Output = Output + "    objDataAdapter = null; \n ";
            Output = Output + "    connection1 = null; \n ";
            Output = Output + "    return Output; \n ";
            Output = Output + "} \n ";
            txt_output_1.Text = Output;
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string Output = "";
            string Server = txt_server.Text.Trim();
            string DataBase = com_db.Text.Trim();
            string User = txt_user.Text.Trim();
            string Pass = txt_password.Text.Trim();
            _ConnectionString = " Data Source=" + Server + ";Initial Catalog= " + DataBase + ";Persist Security Info=True;User ID=" + User + ";Password=" + Pass + " ";
            string TableName = "";
            try
            {
                TableName = list_tables.SelectedItem.ToString();
                if (TableName != string.Empty)
                {
                    if (rad_class.Checked)
                        Output = classMake(TableName);
                    else if (rad_classApi.Checked)
                        Output = classMakeApi(TableName);
                    else if (rad_title.Checked)
                        Output = select_title(TableName);
                    else if (rad_id.Checked)
                        Output = IDfull(TableName);
                    else if (rad_titlefull.Checked)
                        Output = titlefull(TableName);
                    else if (rad_update.Checked)
                        Output = update(TableName);
                    else if (rad_updatefull.Checked)
                        Output = updateFull(TableName);
                    else if (rad_insert.Checked)
                        Output = Insert(TableName);
                    else if (rad_insertfull.Checked)
                        Output = InsertFull(TableName);
                    else if (rad_insertfullOut.Checked)
                        Output = InsertFullOutID(TableName);
                    else if (rad_create.Checked)
                        Output = createMake(TableName);
                    else if (rad_classTtoC.Checked)
                        Output = ClassTtoC(TableName);
                }
                txt_output_1.Text = Output;
            }
            catch { }
        }



        private string IDfull(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);

            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri Select From Table " +  TableName + "  " + DateTime.Now.ToShortDateString() + "  \n ";
                Output = Output + "private " + ClassName + " SelectFrom_" + ClassName.Replace("c_","") + "ById(int id) \n{ \n ";
                Output = Output + "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - dataset \n ";

                Output = Output + " string Codetext = \"  select * from dbo.[" + TableName + "]   where  [id] =  \" + id + \"  \";  \n"
                + "  DataSet1 objDataSet = Select_All_Record_By_TableName(\"" + TableName + "\", Codetext); \n "
                + ClassName + " " + "obj" + ClassName + " = new " + ClassName + "();  \n ";

                Output = Output + " if (objDataSet != null) \n{ \n ";
                Output = Output + " if (objDataSet." + TableName + " != null) \n{ \n";
                Output = Output + " if (objDataSet." + TableName + ".Rows.Count > 0) \n{ \n";

                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));

                    if (type == "double")
                    {
                        Output = Output + "obj" + ClassName + "." + Convert.ToString(Arry[index]) + " =  Convert.ToDouble(objDataSet." + TableName + "[0]." + Convert.ToString(Arry[index]) + "); // " + (index + 1) + "  \n";
                    }
                    else if (type != "false")
                    {
                        Output = Output + "obj" + ClassName + "." + Convert.ToString(Arry[index]) + " = objDataSet." + TableName + "[0]." + Convert.ToString(Arry[index]) + "; // " + (index + 1) + "  \n";
                    }
                }

                Output = Output + "  return " + "obj" + ClassName + " ; \n";

                Output = Output + "} \n";
                Output = Output + "} \n";
                Output = Output + "} \n";

                Output = Output + "  return " + "null ; \n} \n";
            }

            return Output;
        }
        private string titlefull(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);

            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - dataset \n ";



                Output = Output + " string Codetext = \"  select * from dbo.[" + TableName + "]   where  [title] =  N'\" + title + \"'  \";  \n"
                + "  DataSet1 objDataSet = Select_All_Record_By_TableName(\"" + TableName + "\", Codetext); \n "
                + ClassName + " " + "obj" + ClassName + " = new " + ClassName + "();  \n ";


                //if (che_addID.Checked)
                //{
                //    Output = Output + "obj" + ClassName + ".id = objDataSet." + TableName + "[0].id; // 1 \n";
                //    index = 2;
                //}

                //foreach (string s in List)
                //{
                //    if (s.IndexOf(']') != -1)
                //    {
                //        string NS = s.Substring(0, s.IndexOf(']'));
                //        string type = GetDatatype(s);
                //        if (type != "false")
                //        {
                //            Output = Output + "obj" + ClassName + "." + NS + " = objDataSet." + TableName + "[0]." + NS + "; // " + index + "  \n";
                //            index++;
                //        }
                //    }
                //}


                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                    if (type == "double")
                    {
                        Output = Output + "obj" + ClassName + "." + Convert.ToString(Arry[index]) + " =  Convert.ToDouble(objDataSet." + TableName + "[0]." + Convert.ToString(Arry[index]) + "); // " + (index + 1) + "  \n";
                    }
                    else if (type != "false")
                    {
                        Output = Output + "obj" + ClassName + "." + Convert.ToString(Arry[index]) + " = objDataSet." + TableName + "[0]." + Convert.ToString(Arry[index]) + "; // " + (index + 1) + "  \n";
                    }
                }
            }

            Output = Output + "  return " + "obj" + ClassName + " ; ";
            return Output;
        }
        private string update(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);

            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - update \n ";
                Output = Output + " +\"  UPDATE [dbo].[" + TableName + "]  SET \" \n ";

                string DATA = " ";
                string NS = "";
                for (int index = 0; index < Arry.Count; index++)
                {
                    NS = Convert.ToString(Arry[index]);
                    if (NS != "id")
                    {
                        string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                        if (type != "false")
                        {
                            if (type == "string")
                                DATA = DATA + " +\" ,[" + NS + "] = N'\" + obj" + ClassName + "." + NS + " + \"' \"    // " + (index + 1) + "  \n";
                            else if (type == "datetime")
                                DATA = DATA + " +\" ,[" + NS + "] = '\" + obj" + ClassName + "." + NS + " + \"' \"    // " + (index + 1) + "  \n";
                            else if (type == "bool")
                                DATA = DATA + " +\" ,[" + NS + "] =  \" + ConvBoolToStringBit( obj" + ClassName + "." + NS + ")     // " + (index + 1) + "  \n";
                            else
                                DATA = DATA + " +\" ,[" + NS + "] =  \" + Convert.ToString( obj" + ClassName + "." + NS + ")     // " + (index + 1) + "  \n";
                        }
                    }
                }

                DATA = DATA.Substring(DATA.IndexOf(" +\" ,") + 5);
                DATA = " +\"  " + DATA;

                Output = Output + DATA + " +\"  WHERE  [id] = \" + Convert.ToString(obj" + ClassName + ".id)  \n ";
            }
            return Output;
        }
        private string updateFull(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);

            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - update \n ";
                Output = Output + " string Text_Execute = \"  declare @ret int set @ret = 0; begin tran  begin try  \" \n ";
                Output = Output + " +\"  UPDATE [dbo].[" + TableName + "]  SET \" \n ";

                string DATA = " ";
                string NS = "";
                for (int index = 0; index < Arry.Count; index++)
                {
                    NS = Convert.ToString(Arry[index]);
                    if (NS != "id")
                    {
                        string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                        if (type != "false")
                        {
                            if (type == "string")
                                DATA = DATA + " +\" ,[" + NS + "] = N'\" + obj" + ClassName + "." + NS + " + \"' \"    // " + (index + 1) + "  \n";
                            else if (type == "datetime")
                                DATA = DATA + " +\" ,[" + NS + "] = '\" + obj" + ClassName + "." + NS + " + \"' \"    // " + (index + 1) + "  \n";
                            else if (type == "bool")
                                DATA = DATA + " +\" ,[" + NS + "] =  \" + ConvBoolToStringBit( obj" + ClassName + "." + NS + ")     // " + (index + 1) + "  \n";
                            else
                                DATA = DATA + " +\" ,[" + NS + "] =  \" + Convert.ToString( obj" + ClassName + "." + NS + ")     // " + (index + 1) + "  \n";
                        }
                    }
                }

                DATA = DATA.Substring(DATA.IndexOf(" +\" ,") + 5);
                DATA = " +\"  " + DATA;

                Output = Output + DATA + " +\"  WHERE  [id] = \" + Convert.ToString(obj" + ClassName + ".id)  \n ";
                Output = Output + "   + \"   set @ret = 1; commit tran   end try   begin catch  rollback tran   set @ret = 0; end catch   select @ret as 'ret' \"; \n "
                      + "   return ExecuteNonQuery_Function_ret_Boolean(Text_Execute); ";
            }
            return Output;
        }
        private string Insert(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);
            int counter = 1;

            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - insert \n ";
                Output = Output + " + \" INSERT INTO [dbo].[" + TableName + "]  ( ";

                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                    if (Arry[index].ToString() != "id")
                    {
                        if (type != "false")
                            Output = Output + "[" + Arry[index] + "],";

                        if (counter >= 8)
                        {
                            Output = Output + " \" \n + \" ";
                            counter = 0;
                        }
                        counter++;
                    }
                }

                Output = Output.Substring(0, Output.LastIndexOf(','));
                Output = Output + ") \"  \n + \"   VALUES  (  \"  ";

                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                    if (Arry[index].ToString() != "id")
                    {
                        if (type != "false")
                        {
                            if (type == "string")
                                Output = Output + " + \" N'\" + obj" + ClassName + "." + Arry[index] + " + \"' ,\" \n";
                            else if (type == "datetime")
                                Output = Output + " + \"  '\" + obj" + ClassName + "." + Arry[index] + " + \"'  ,\" \n";
                            else if (type == "bool")
                                Output = Output + " + ConvBoolToStringBit( obj" + ClassName + "." + Arry[index] + ") + \" ,\" \n";
                            else
                                Output = Output + " + Convert.ToString( obj" + ClassName + "." + Arry[index] + ") + \" ,\" \n";
                        }
                    }
                }

                Output = Output.Substring(0, Output.LastIndexOf(','));
                Output = Output + ") \" ";

            }
            return Output;
        }
        private string InsertFull(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);
            int counter = 1;

            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - insert \n ";
                Output = Output + " string Text_Execute = \"  declare @ret int set @ret = 0; begin tran  begin try  \" \n ";
                Output = Output + " + \" INSERT INTO [dbo].[" + TableName + "]  ( ";

                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                    if (Arry[index].ToString() != "id")
                    {
                        if (type != "false")
                            Output = Output + "[" + Arry[index] + "],";

                        if (counter >= 8)
                        {
                            Output = Output + " \" \n + \" ";
                            counter = 0;
                        }
                        counter++;
                    }
                }

                Output = Output.Substring(0, Output.LastIndexOf(','));
                Output = Output + ") \"  \n + \"   VALUES  (  \"  ";

                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                    if (Arry[index].ToString() != "id")
                    {
                        if (type != "false")
                        {
                            if (type == "string")
                                Output = Output + " + \" N'\" + obj" + ClassName + "." + Arry[index] + " + \"' ,\" \n";
                            else if (type == "datetime")
                                Output = Output + " + \"  '\" + obj" + ClassName + "." + Arry[index] + " + \"'  ,\" \n";
                            else if (type == "bool")
                                Output = Output + " + ConvBoolToStringBit( obj" + ClassName + "." + Arry[index] + ") + \" ,\" \n";
                            else
                                Output = Output + " + Convert.ToString( obj" + ClassName + "." + Arry[index] + ") + \" ,\" \n";
                        }
                    }
                }

                Output = Output.Substring(0, Output.LastIndexOf(','));
                Output = Output + ") \" ";
                Output = Output + "   + \"   set @ret = 1; commit tran   end try   begin catch  rollback tran   set @ret = 0; end catch   select @ret as 'ret' \"; \n "
                                      + "   return ExecuteNonQuery_Function_ret_Boolean(Text_Execute); ";

            }
            return Output;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            string FileName = "opt.txt";
            string Server = "", db = "", username = "", passw = "";
            string error = "";
            FMS fs = new FMS();

            Server = txt_server.Text.Trim();
            db = com_db.Text.Trim();
            username = txt_user.Text.Trim();
            passw = txt_password.Text.Trim();

            if (fs.SaveToFile(FileName, "serverName", Server, out error))
            {
            }

            if (fs.SaveToFile(FileName, "dbName", db, out error))
            {
            }

            if (fs.SaveToFile(FileName, "username", username, out error))
            {
            }

            if (fs.SaveToFile(FileName, "password", passw, out error))
            {
            }


        }

        private string InsertFullOutID(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);
            int counter = 1;

            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - insert i \n ";
                Output = Output + "// , out int ID \n  ";
                Output = Output + "bool shart = false; \n ";
                Output = Output + "int IDF = 0; \n  ";
                Output = Output + " string Text_Execute = \"  declare @ret int set @ret = 0; begin tran  begin try  \" \n ";
                Output = Output + " + \" INSERT INTO [dbo].[" + TableName + "]  ( ";

                string wss = "ws";
                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));

                    if (Arry[index].ToString() == "ws") wss = "ws";
                    else if (Arry[index].ToString() == "ws_id") wss = "ws_id";

                    if (Arry[index].ToString() != "id")
                    {
                        if (type != "false")
                            Output = Output + "[" + Arry[index] + "],";

                        if (counter >= 8)
                        {
                            Output = Output + " \" \n + \" ";
                            counter = 0;
                        }
                        counter++;
                    }
                }

                Output = Output.Substring(0, Output.LastIndexOf(','));
                Output = Output + ") \"  \n + \"   VALUES  (  \"  ";

                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                    if (Arry[index].ToString() != "id")
                    {
                        if (type != "false")
                        {
                            if (type == "string")
                                Output = Output + " + \" N'\" + obj" + ClassName + "." + Arry[index] + " + \"' ,\" \n";
                            else if (type == "datetime")
                                Output = Output + " + \"  '\" + obj" + ClassName + "." + Arry[index] + " + \"'  ,\" \n";
                            else if (type == "bool")
                                Output = Output + " + ConvBoolToStringBit( obj" + ClassName + "." + Arry[index] + ") + \" ,\" \n";
                            else
                                Output = Output + " + Convert.ToString( obj" + ClassName + "." + Arry[index] + ") + \" ,\" \n";
                        }
                    }
                }

                Output = Output.Substring(0, Output.LastIndexOf(','));
                Output = Output + ") \" ";
                Output = Output + "   + \" set @ret = ( select max([id]) from [dbo].[" + TableName + "] where [" + wss + "] = \"+aa_Items.WorkStation_id+\" ) ; commit tran   end try   begin catch  rollback tran   set @ret = 0; end catch   select @ret as 'ret' \"; \n ";
                Output = Output + " shart = InsertToDB_ReturnID(Text_Execute, out IDF); \n ";
                Output = Output + " ID = IDF; \n ";
                Output = Output + "  return shart; \n ";

            }

            return Output;
        }


        private string ClassTtoC(string TableName)
        {
            string Output = "";
            string ClassName = TableName.Replace("t_", "c_");
            txt_nameClass.Text = ClassName;
            txt_nametable.Text = TableName;
            ArrayList ArryDataType;
            ArrayList Arry = GetColoumnNames(_ConnectionString, TableName, out ArryDataType);

            if (Arry.Count != 0)
            {
                Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - Class T to C i \n ";
                Output = Output + ClassName + " cm = new  " + ClassName + "(); \n";

                for (int index = 0; index < Arry.Count; index++)
                {
                    string type = GetDatatype(Convert.ToString(ArryDataType[index]));
                    if (type != "false")
                    {
                        if (type == "double")
                            Output = Output + " cm." + Arry[index] + " = Convert.ToDouble(tm." + Arry[index] + ");  // " + (index + 1) + "  \n";
                        else
                            Output = Output + " cm." + Arry[index] + " = tm." + Arry[index] + ";   // " + (index + 1) + "  \n";
                    }
                }

                Output = Output + " return cm; \n ";

            }

            return Output;
        }

        private string createMake(string tableName)
        {
            return " ";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string Output = " ";
            Output = "//  Generate Code By Auto Code Generator Mehdi Moshiri " + DateTime.Now.ToShortDateString() + " - For Loop Detail \n ";
            Output = Output + " int XDS = dgv1.Rows.Count; \n  ";
            Output = Output + " for (int index = 0; index < XDS; index++) \n ";
            Output = Output + " { \n ";
            Output = Output + "     dgv1[1, index].Value = index + 1;  \n  ";
            Output = Output + " \n  ";
            Output = Output + "     if (index % 2 == 0) \n   ";
            Output = Output + "     {  \n  ";
            Output = Output + "         dgv1.Rows[index].DefaultCellStyle.BackColor = Color.White; \n  ";
            Output = Output + "     } \n ";
            Output = Output + "     else \n  ";
            Output = Output + "     { \n  ";
            Output = Output + "         dgv1.Rows[index].DefaultCellStyle.BackColor = Color.LightCyan;  \n ";
            Output = Output + "     } \n ";
            Output = Output + " } \n  ";
            Output = Output + " \n ";
            Output = Output + " try \n  ";
            Output = Output + " { \n ";
            Output = Output + "     if (XDS != 0) \n  ";
            Output = Output + "     { \n ";
            Output = Output + "         dgv1.Rows[XDS - 1].Selected = true;  \n ";
            Output = Output + "         dgv1.CurrentCell = dgv1[1, XDS - 1];  \n ";
            Output = Output + " \n  ";
            Output = Output + "     }  \n ";
            Output = Output + " } \n ";
            Output = Output + " catch \n ";
            Output = Output + " { } \n ";
            txt_output_1.Text = Output;
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadDataBase();
        }
    }
}


