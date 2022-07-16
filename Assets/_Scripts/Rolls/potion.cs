class potion{
    int efficacy = 1;

    public potion(int efficacy, int numSides){
        this.efficacy = efficacy;
        base.numSides = numSides;
    }

    void heal(Entity target){
        target.heal(rnd.Next(base.numSides) * efficacy);
    }
}