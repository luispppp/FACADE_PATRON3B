class Documento: Impresora
{
   
    public Documento(string Nombre, string Hoja, string Texto, int Nhoja) : base(Nombre, Hoja, Texto, Nhoja)
    {
      
    }
    public void imprimir()
    {
         Console.WriteLine("el numero de hojas que se imprimira es: " + Nhoja);
    }
    public override void ImprirmirDoc()
    {
        int i = 0;
        for(i=0; i<=Nhoja; i++)
        {
            Console.WriteLine("el nombre de su documento es: " + Nombre);
        Console.WriteLine("el formato de su documento es: " + Hoja);
        Console.WriteLine("el texto escrito en su documento es: " + Texto);
       
        }
    }
}