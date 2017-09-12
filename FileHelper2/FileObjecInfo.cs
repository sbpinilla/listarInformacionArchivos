using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listarInformacionArchivos
{
	public class FileObjecInfo
	{

		public string Path { get; set; }
		public string Name{ get; set; }
		public FileObjecType  FileType
		{ get; set; }
	}
}
