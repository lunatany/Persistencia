
using System;
using System.IO;
using System.Collections;
[Serializable]
class ArchivoVector
{
   private string nombre;
   public ArchivoVector(string n)
   {
   	nombre=n;
   }
   public void crearNuevo() {
          if( System.IO.File.Exists(nombre) ) {
                Console.WriteLine("Realmente quiere borrar el archivo?. s/n");
                if( Console.ReadKey().KeyChar == 's' )
                    System.IO.File.Delete(nombre);
            }
            else
                Console.WriteLine("El archivo no existe.");
        }
       public void adicionar() 
       {
            Stream arch = File.Open(nombre, FileMode.Append);
            BinaryWriter escritor = new BinaryWriter(arch);
           // Vector v = new Vector();
            try {
                do {
           		    Console.Write("tamño del vector?");
           		    int n=int.Parse(Console.ReadLine());
            	     Vector v = new Vector(n);
                    v.leer();
                    //escritor.Seek(0,SeekOrigin.End);
                    v.escribeAV(escritor);
                    Console.Write("Desea continuar añadiendo registros? s/n => ");
                } while( Console.ReadKey().KeyChar == 's' );
            }
            catch( Exception ) {
                Console.WriteLine("Fallo en adicionar el objeto !!!");
            }
            finally {
                arch.Close();
            }
       }
       
       public void listar()
       {
       	Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
       	BinaryReader lector=new BinaryReader(arch);
       	Vector v=new Vector(4);
       	try
       	{
       		while(true)
       		{
       			v.leeAV(lector);
       			Console.Write("\n");
       			v.mostrar();
       		}
       	}
       	catch(Exception )
       	{
       		Console.WriteLine("Fin Archivo");
       	}
        finally
        {
        	arch.Close();
        }
       }
       //
       public int repite(int e)
       {
       	Stream arch=File.Open(nombre,FileMode.OpenOrCreate);
       	BinaryReader lector=new BinaryReader(arch);
       	int c=0;
       	Vector v=new Vector(4);
       	try
       	{
       		while(true)
       		{
       			v.leeAV(lector);
       			for(int i=1;i<=v.getN();i++){
       				if(v.getElement(i)==e){
       					c++;
       				}
       				
       			}
       			Console.Write("\n");
       			v.mostrar();
       		}
       	}
       	catch(Exception )
       	{
       		Console.WriteLine("Fin Archivo");
       	}
        finally
        {
        	arch.Close();
        	
        }
        return c;
       }

   
}
