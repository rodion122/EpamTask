using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Task.DAL
{
	public static class FileManager
	{
		public static string[] ReadInformation(string filePath)
		{
			FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			StreamReader read = new StreamReader(file);
			StringBuilder result = new StringBuilder();

			while (!read.EndOfStream)
				result.Append(read.ReadLine() + "\n");
			
			read.Close();
			Regex.Replace(result.ToString().Trim(), @"\s+", " ");
			return result.ToString().TrimEnd().Split('\n');
		}

		public static void WriteInformation(string filePath, string[] information)
		{
			FileStream file = new FileStream(filePath, FileMode.Append, FileAccess.Write);
			StreamWriter write = new StreamWriter(file);
			for (int i = 0; i < information.Length; i++)
				write.WriteLine(information[i]);
			write.Close();
		}
	}
}
