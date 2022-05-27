using System;	
public class Principal
	{
	public static void Main(string []arg)		
	{
		 bool sw = true;
         Console.ForegroundColor = ConsoleColor.DarkMagenta;
         Console.BackgroundColor = ConsoleColor.Yellow;
            while( sw ) {
                Console.WriteLine("\n                                      ");
                Console.WriteLine("          MENU                          ");
                Console.WriteLine("     ARCHIVO VECTOR                     ");
                Console.WriteLine("     ===============                    ");
                Console.WriteLine("                                        ");
                Console.WriteLine("1. CREAR                                ");
                Console.WriteLine("2. ADICIONAR                            ");
                Console.WriteLine("3. LISTAR                               ");
                Console.WriteLine("4. MUESTRA REPETICION DE ELEMENTO                                     ");
                Console.WriteLine("5. SALIR                                ");
                Console.WriteLine("                                        ");
                Console.Write("INTRODUZCA  UNA  OPCION             =>      ");
                
                ArchivoVector av= new ArchivoVector(@"F:\vec.dat");
                switch( Console.ReadKey().KeyChar ) {
                    case '1':
                        av.crearNuevo();
                        break;
                    case '2':
                        av.adicionar();
                        break;
                    case '3':
                        av.listar();
                        break;
                    case '4':
                        Console.WriteLine(av.repite(2));
                        
                        break;
                    default:
                        Console.WriteLine("\n   El programa ya termino  !!!");
                        Console.Beep();
                        sw = false;
                        break;
                }
			
			
			Console.ReadKey();
		 }
	}
}
