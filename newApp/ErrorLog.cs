/*
 * Created by Ranorex
 * User: TQA-SIM1
 * Date: 10/5/2023
 * Time: 5:56 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Linq;
using System.Diagnostics;
using WinForms = System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace newApp
{
	/// <summary>
	/// Description of ErrorLog.
	/// </summary>
	public class ErrorLog
	{


		public static void LogExport(string str)
		{
			try 
			{
				//string iniLInk = Environment.CurrentDirectory + @"\" + "config.ini";
				//string strIniLogPath = SupportClass.iniConfig.readIni(iniLInk,"LOG","strLogPath");
				string crrPath = iniConfig.RelativeToFullPath(@"...");
				string strFilePath = crrPath +@"\Log\Log_" + System.DateTime.Today.ToString("yyyyMMdd") + ".log";
				string strDirPath =  crrPath + @"\Log";
				string strTemp;
				DirectoryInfo di = new DirectoryInfo(strDirPath);
				FileInfo fi = new FileInfo(strFilePath);
				if(!di.Exists) Directory.CreateDirectory(strDirPath);
				if(!fi.Exists)
				{
					using(StreamWriter sw = new StreamWriter(strFilePath))
					{
						strTemp = string.Format("[{0}] {1}",System.DateTime.Now,str);
						sw.WriteLine(strTemp);
						sw.Close();
					}
				}else
				{
					using(StreamWriter sw = File.AppendText(strFilePath))
					{
						strTemp = string.Format("[{0}] {1}",System.DateTime.Now,str);
						sw.WriteLine(strTemp);
						sw.Close();
					}
				}
			} catch (Exception) 
			{
				
				
			}

		}
	}
}
