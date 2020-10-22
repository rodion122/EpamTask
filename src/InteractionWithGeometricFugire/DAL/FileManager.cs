using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace InteractionWithGeometricFugire.DAL
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
	}
}