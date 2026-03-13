abstract class Character
{
    protected string _type;
    protected bool _isVulnerable;
    protected Character(string characterType)
    {
        _type = characterType;
        _isVulnerable = false;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return _isVulnerable;
    }

    public override string ToString()
    {
        return $"Character is a {_type}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable()) {
            return 10;
        }
        return 6;
    }
}

class Wizard : Character
{
    private bool _isSpellPrepared;
    public Wizard() : base("Wizard")
    {
        _isVulnerable = true;
    }

    public override int DamagePoints(Character target)
    {
        if (_isSpellPrepared) {
            return 12;
        }
        return 3;
    }

    public void PrepareSpell()
    {
        if (!_isSpellPrepared)
        {
            this._isSpellPrepared = true;
            this._isVulnerable = false;
        }
    }
}
