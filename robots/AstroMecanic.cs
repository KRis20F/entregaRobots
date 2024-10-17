public class DroideAstromecanic : Robots {

    public DateTime LastRepaired{ get; set; }
    public DroideAstromecanic(string name, int tipoUnidad , int bateria,DateTime LastRepaired ) : base(name, tipoUnidad , bateria) {
        this.LastRepaired = LastRepaired;
    }

    public int repairedships(){
        Random rand = new Random();
        int repairships = rand.Next(1,10);
        return repairships;
    }
    
    public void lastReparation(){
        Console.WriteLine($"La ultima reparacion de {Name} fue {LastRepaired}");
    }

}

