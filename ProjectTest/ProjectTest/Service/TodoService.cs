using System;
using System.Text;

namespace ProjectTest.Service
{
	public class TodoService
	{
		private IConfigurationRoot configuration;
		private string FILE_PATH;
		
		public TodoService()
		{
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(path: "appsettings.json");
            this.configuration = builder.Build();

            string fileName = configuration["TodoFileName"] ?? "TodoFile2.txt";
            this.FILE_PATH = @"C:" + fileName;
        }

		public void ReadFile()
		{
				//ファイル存在なし
				//ファイル作成
				//File.Create(FILE_PATH);
				File.AppendAllText(FILE_PATH, "");
		}

		private bool FileCheck()
		{


			if (File.Exists(FILE_PATH))
			{
/*
				StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("Shit_JIS"));

				string str = sr.ReadToEnd();

				sr.Close();
*/
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

