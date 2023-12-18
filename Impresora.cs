class Impresora
{
    protected string Nombre{get; set;}
    protected string Hoja{get; set;}
    protected string Texto{get; set;}
    protected int Nhoja{get; set;}

    public Impresora(string Nombre, string Hoja, string Texto, int Nhoja)
    {
        this.Nombre=Nombre;
        this.Hoja=Hoja;
        this.Texto=Texto;
        this.Nhoja=Nhoja;
    }
    
    public virtual void ImprirmirDoc()
    {

    }
   
}