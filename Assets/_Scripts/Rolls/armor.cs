class Armor : Dice{
    int evasionNum = 1;
    double defense;

    public Armor(string name, int numSides, int evasionNum, double defense){
        this.defense = defense;
        this.evasionNum = evasionNum;
        base.numSides = numSides;
        base.name = name;
    }

    double defend(Entity target){
        int rng = random.Next(base.numSides);
        if(rng == evasionNum){
            return -10;
        }else{
            return rng * defense - 1;
        }
    }
}