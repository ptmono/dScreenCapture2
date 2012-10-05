using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Libs
{
    public class ImageContainer
    {
	private string path_filename = "crop_path.txt";
	public string basePath = "";

	public String getNewFilename()
	    {
		String basePath = this.getPath();

		// Create new filename
		int lastest_num = this.getLastestNumber(basePath);
		int new_num = lastest_num + 1;
		String new_num_str = new_num.ToString();
		Console.WriteLine(new_num_str);
		String new_filename = basePath + "\\image" + new_num_str + ".jpg";
		return new_filename;
	    }

	public int getLastestNumber(String dir)
	    {
		var accuracy = 20;
		var start = 1;
		List<int> result_list = new List<int>();

		// Get lastest file
		var directory = new DirectoryInfo(dir);
		var files = directory.GetFiles()
		    .OrderByDescending(f => f.LastWriteTime);

		// To increase speed we use some region
		// FIXME: conside more useful way
		foreach (var a in files)
		{
		    if (start <= accuracy)
		    {
			var num = (int)getNum(a.Name);
			if (num > 0)
			{
			    result_list.Add(num);
			}
			start++;
		    }
		}

		result_list.Sort();
		result_list.Reverse();
		return result_list[0];
	    }

	private uint getNum(String file_name)
	    {
		String regexp_num = "image([0-9]+).jpg";
		String filename = Path.GetFileName(file_name);
		Match match = Regex.Match(filename, regexp_num);
		
		if (match.Success)
		{
		    String num_str = match.Groups[1].Value;
		    uint result = Convert.ToUInt32(num_str);
		    return result;
		}
		else
		{
		    return 0;
		}
	    }
	public String getPath()
	    {
		try
		{
		    TextReader tr = new StreamReader(this.path_filename);
		    return tr.ReadLine();
		}
		catch(Exception ex)
		{
		    FolderBrowserDialog folderDlg = new System.Windows.Forms.FolderBrowserDialog();
		    folderDlg.Description = "Select the directory that you want to use as the default.";
		    //folderDlg.RootFolder = Environment.SpecialFolder.Personal;
		    DialogResult result = folderDlg.ShowDialog();
		    if(result == DialogResult.OK)
		    {
			this.basePath = folderDlg.SelectedPath;
			TextWriter tw = new StreamWriter(this.path_filename);
			tw.WriteLine(this.basePath);
			tw.Close();
		    }
		    else
		    {
			throw new System.ArgumentNullException();
		    }

		    return this.basePath;
		}
	    }
    }
    
}


