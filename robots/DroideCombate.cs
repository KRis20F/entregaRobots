public class DroideCombate : Robots{
    public int firePoints { get; set; }

    public DroideCombate (string name,int tipoUnidad , int bateria, int firePoints) : base(name, tipoUnidad , bateria){
        this.firePoints = firePoints;
    }

    public int allNumberFigth(){
        Random rand = new Random();
        return rand.Next(1,20);
    }

    public override void viewDetails()
    {
        Console.WriteLine($"Nombre: {Name}, Tipo: {TipoUnidad}, Batería: {Bateria}%, Potencia de fuego: {firePoints}");
    }

}