using System;
using System.Collections.Generic;

public class Robots {
    public string Name { get; set; }
    public int TipoUnidad { get; set; }
    public int Bateria {get; set;}

    public Robots(string name, int tipoUnidad, int bateria)
    {
        this.Name = name;
        this.TipoUnidad = tipoUnidad;
        this.Bateria = bateria;
    }


    public virtual void viewDetails() {
        Console.WriteLine("Nombre : " + this.Name + ", Su tipo de unidad: " + this.TipoUnidad +  ", Su bateria: " + this.Bateria);
    }
}