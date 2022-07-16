class potion : dice{
    int evasionNum = 1;
    double defense;

    public potion(string name, int numSides, int evasionNum, double defense){
        this.defense = defense;
        this.evasionNum = evasionNum;
        base.numSides = numSides;
        base.name = name;
    }

    double defend(Entity target){
        int rng = rnd.Next(base.numSides);
        if(rng == evasionNum){
            return -10;
        }else{
            return rng * defense - 1;
        }
    }
}