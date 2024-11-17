using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace CodeClassGenerator
{
    public class FMS
    {
        string Spliter = "%";

        public bool SaveToFile(string FileName, string title, string Value, out string Error)
        {
            bool shart = false;
            try
            {
                if (!File.Exists(FileName))
                {
                    // New File
                    string[] Items = new string[1];
                    Items[0] = title + Spliter + Value + Spliter;

                    FileStream FS = File.Create(FileName);
                    FS.Close();
                    File.WriteAllLines(FileName, Items, Encoding.Unicode);
                    shart = true;
                }
                else
                {
                    //  Update File 
                    bool SaveLine = false;
                    string[] lineOfContents = File.ReadAllLines(FileName);
                    string[] Items = new string[lineOfContents.Length + 1];

                    for (int index = 0; index < Math.Max(lineOfContents.Length, 1); index++)
                    {
                        if (lineOfContents[index].IndexOf(Spliter) != -1)
                        {
                            if (lineOfContents[index].Substring(0, lineOfContents[index].IndexOf(Spliter)) == title)
                            {
                                lineOfContents[index] = title + Spliter + Value + Spliter;
                                SaveLine = true;
                            }
                            Items[index] = lineOfContents[index];
                        }
                    }

                    if (!SaveLine)
                    {
                        Items[Items.Length - 1] = title + Spliter + Value + Spliter;
                        File.WriteAllLines(FileName, Items, Encoding.Unicode);
                        shart = true;
                    }
                    else
                    {
                        File.WriteAllLines(FileName, lineOfContents, Encoding.Unicode);
                        shart = true;
                    }
                }
                Error = "ok";
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                shart = false;
            }

            Thread.Sleep(30);
            return shart;
        }

        public bool ReadFromFile(string FileName, string title, out string Value, out string Error, string defaultValue = "")
        {
            bool shart = false;
            bool findLine = false;
            string Vout = " ";
            string Eout = " ";
            try
            {
                if (!File.Exists(FileName))
                {
                    try
                    {
                        // New File
                        string[] Items = new string[1];
                        Items[0] = title + Spliter + defaultValue + Spliter;

                        FileStream FS = File.Create(FileName);
                        FS.Close();
                        File.WriteAllLines(FileName, Items, Encoding.Unicode);
                    }
                    catch { }
                }



                if (File.Exists(FileName))
                {


                    string[] lineOfContents = File.ReadAllLines(FileName);

                    for (int index = 0; index < lineOfContents.Length; index++)
                    {
                        if (lineOfContents[index].IndexOf(Spliter) != -1)
                        {
                            if (lineOfContents[index].Substring(0, lineOfContents[index].IndexOf(Spliter)) == title)
                            {
                                Vout = lineOfContents[index].Substring(lineOfContents[index].IndexOf(Spliter)).Replace(Spliter, "");
                                findLine = true;
                                shart = true;
                                Eout = "ok";
                                break;
                            }
                        }
                    }


                    if (!findLine)
                    {
                        if (SaveToFile(FileName, title, defaultValue, out Eout))
                        {
                            Vout = defaultValue;
                            shart = true;
                            Eout = "ok";
                        }
                        else
                        {
                            Vout = " ";
                            shart = false;
                            Eout = " In File " + FileName + "  Variable : " + title + "  Not Exist and save Nashod ";
                        }
                    }
                }
                else
                {
                    Vout = " ";
                    shart = false;
                    Eout = "File " + FileName + " Not Exist";
                }

            }
            catch (Exception ex)
            {
                Vout = " ";
                Eout = ex.Message;
                shart = false;
            }

            Thread.Sleep(30);
            Value = Vout;
            Error = Eout;
            return shart;
        }

    }
}
