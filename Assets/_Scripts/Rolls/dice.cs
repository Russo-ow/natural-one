class Dice{
    string name;
    int numSides;
    Entity owner;
    
    public Dice(string name, int numSides, Entity owner){
        this.name = name;
        this.numSides = numSides;
        this.owner = owner;
    }

    public Dice(string name, int numSides){
        this.name = name;
        this.numSides = numSides;
    }
/*
    Object roll(Entity owner, Entity target){
        int rng = rnd.Next(numSides);
        return dice.call(rng);
    }

    Object call(int rng){
        if(rng >= numSides){
            return -1;
        }
    }
*/
}