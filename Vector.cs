
using System;
using System.IO;
[Serializable]
public class Vector
	{
		private int [] v =new int [30];
		private int n;
    public int getElement(int i)
    {
        return v[i];
    }
    public int getN()
    {
        return n;
    }
		public Vector(int t)
		{
			n=t;
		}
		public void leer()
		{
			for (int i=1;i<=n;i++)
			{
				Console.Write("Elemento?");
				v[i]=Leer.Integer();
			}
		}
		public void mostrar()
		{
			for (int i=1;i<=n;i++)
				Console.Write("["+v[i]+"]");
		}
		
		public void escribeAV(BinaryWriter escritor)
		{
			escritor.Write(n);
			for (int i=1;i<=n;i++)
				escritor.Write(v[i]);
		}
		public void leeAV(BinaryReader lector)
		{
			n=lector.ReadInt32();
			for (int i=1;i<=n;i++)
			{
				v[i]=lector.ReadInt32();
				
			}
		}
	}
