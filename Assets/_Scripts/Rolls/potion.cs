using UnityEngine;

public class Potion : Dice{
    int efficacy = 1;

    public Potion(int efficacy, int numSides){
        this.efficacy = efficacy;
        base.numSides = numSides;
    }

    void heal(Entity target){
        target.Heal(Random.Range(0, base.numSides) * efficacy);
    }
}