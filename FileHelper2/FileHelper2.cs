using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listarInformacionArchivos
{
	public class FileHelper2
	{

		public List<FileObjecInfo> getFileList(String path)
		{


			DirectoryInfo di = new DirectoryInfo(path);

			var listInf = di.EnumerateFileSystemInfos();

			var listFailObject = new List<FileObjecInfo>();
			foreach (var item in listInf)
			{

				FileObjecType tipo = FileObjecType.Directory;

				if (item.Attributes == FileAttributes.Archive)
					tipo = FileObjecType.File;


				listFailObject.Add(new FileObjecInfo() { Path = item.FullName, Name = item.Name, FileType = tipo });
			}

			return listFailObject;

		}
	}
}
