class Weapon : Dice{
    string weaponClass;
    int strength;

    public Weapon(string name, string weaponClass, int strength, int numSides){
        base.name = name;
        this.weaponClass = weaponClass;
        this.strength = strength;
        base.numSides = numSides;
    }

    void dealDamage(Entity target)
    {
        int rng = random.Next(base.numSides);
        target.TakeDamage(rng * strength);
    }

    void heal(Entity target)
    {
        int rng = rnd.Next(base.numSides);
        target.heal(rng * strength);
    }
}