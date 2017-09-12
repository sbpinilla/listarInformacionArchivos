using System;


namespace listarInformacionArchivos
{
	class Program
	{
		static void Main(string[] args)
		{
			FileHelper2 fh = new FileHelper2();


			var respuesta = fh.getFileList("./");


			foreach(var item in respuesta)
			{


				Console.WriteLine($"Nombre:{item.Name}");
				Console.WriteLine($"Path:{item.Path}");
				Console.WriteLine($"Tipo:{item.FileType}");
				Console.WriteLine("------------------------");

			}

			Console.ReadLine();
		}
	}
}
