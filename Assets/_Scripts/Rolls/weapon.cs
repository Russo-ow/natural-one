class weapon : dice{
    String weaponClass;
    int strength;

    public weapon(String name, String weaponClass, int strength, int numSides){
        base.name = name;
        this.weaponClass = weaponClass;
        this.strength = strength;
        base.numSides = numSides;
    }

    void dealDamage(Entity target)
    {
        int rng = rnd.Next(base.numSides);
        target.takeDamage(rng * strength);
    }

    void heal(Entity target)
    {
        int rng = rnd.Next(base.numSides);
        target.heal(rng * strength);
    }
}