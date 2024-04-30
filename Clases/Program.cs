using System.Drawing;

public class Clases
{

    public static void Main()
    {
        Puerta puerta1 = new Puerta();
        puerta1.abrir();
        puerta1.MostrarEstado();

        Porton porton1 = new Porton();
        porton1.bloquear();
        porton1.MostrarEstado();
        porton1.desbloquear();
        porton1.MostrarEstado();



        Puerta[] arrayPuerta = new Puerta[5];
    }
}

public class Puerta{
    protected int ancho { set; get; } /*Proteger atributos a nivel de herencia*/
    protected String? color { set; get; }
    protected int alto { set; get; }
    protected bool abierto { set; get; }

    //constructor Vacio (es por defecto, pero acá todo)
    public Puerta() { }

    //constructor
    public Puerta(int ancho, int alto, string color, bool abierto)
    {
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
        this.abierto = abierto;
    }


    ~Puerta(){//Destruir contructor

        //Liberra memoria
        //Cerrar ficheros
    }


        public bool abrir() {
        return abierto = true;
    }

    public bool cerrar()
    {
        return abierto = false;  
    }

    public void MostrarEstado() {
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Estado: {0}", abierto);

    }

}

public class Porton:Puerta{ /*La herencia se hace por medio de 2 puntos*/
    bool bloqueada;

    public bool bloquear()
    {
        return bloqueada = true;
    }

    public bool desbloquear()
    {
        return bloqueada=false;
    }


    public new void MostrarEstado()
    {
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Estado: {0}", abierto);
        Console.WriteLine("Bloqueada: {0}", bloqueada);

    }
}


