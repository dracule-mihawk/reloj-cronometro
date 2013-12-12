using System;

namespace Reloj_Crono
{
	class Reloj_Crono
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("\r\nSeleccione una opcion:\r\n");
			Console.WriteLine("1)Reloj \r\n2)Cronometro");
			String opcion = Console.ReadLine();
			int opc = int.Parse(opcion);
			switch (opc) 
			{
				case 1:	Console.WriteLine("\rEntrando a modo reloj");
			    		new Reloj();
						break;			
				case 2: Console.WriteLine("\rEntrando a modo cronometro");
						new cronometro();
						break;
				default:Console.WriteLine("La opcion que Seleccione no Existe");
						break;
			}
		}
	}
}
