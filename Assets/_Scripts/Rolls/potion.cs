class Potion : Dice{
    int efficacy = 1;

    public Potion(int efficacy, int numSides){
        this.efficacy = efficacy;
        base.numSides = numSides;
    }

    void heal(Entity target){
        target.heal(random.Next(base.numSides) * efficacy);
    }
}