class Fachada
{
    private Impresora impresora;
    private Documento documento;
    public Fachada()
    {
        this.impresora = new Impresora("Doc1","A4","paseme de semestre:(", 4);
        this.documento = new Documento("Doc1","A4","paseme de semestre:(", 4);
    }
    public void ImprimirHoja()
    {
        documento.ImprirmirDoc();
    }
}