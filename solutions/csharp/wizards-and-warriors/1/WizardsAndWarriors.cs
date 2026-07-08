abstract class Character
{
    // Field
    private string _characterType;
    // Constructor
    protected Character(string characterType)
    {
        _characterType = characterType;
    }
    // Method 1 - Abstract - Must be implemented
    public abstract int DamagePoints(Character target);
    // Method 2 - Virtual - Derived classes can change implementation
    public virtual bool Vulnerable()
    {
        return false;
    }
    // Inherited from object class - which can be be overriden
    public override string ToString()
    {
        return $"Character is a {_characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        // 6 pts of damage if character they are attacking is not vulnerable
        // 10 pts of damage if character they are attacking is vulnerable
        return target.Vulnerable() ? 10 : 6;
    }
}

class Wizard : Character
{
    private bool preparedSpell = false;
        
    public Wizard() : base("Wizard")
    {
    }

    public void PrepareSpell()
    {
        preparedSpell = true;
    }

    public override bool Vulnerable()
    {
       return !preparedSpell; 
    }

    public override int DamagePoints(Character target)
    {
        // 12  pts of damage if wizard prepared a spell in advance
        // 3 pts of damage if wizard did not prepare a spell in advance       
        if (preparedSpell == true)
            return 12;
        return 3;
    }
}
