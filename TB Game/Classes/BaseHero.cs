using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable()]
abstract class BaseHero : ISerializable
{
    private string name;
    protected int curH ;
    protected int maxH;
    protected int defense;
    protected int attack;
    protected int agility;

    public virtual string Status()
    {
        Console.WriteLine($"{name} has {maxH} health, {defense} defense, {attack} attack power and {agility} speed");
        return Status();
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Name", name);
        info.AddValue("Max Health", maxH);
        info.AddValue("Attack", attack);
        info.AddValue("Defense", defense);
        info.AddValue("Agility", agility);
    }

    public Hero (SerializationInfo info, StreamingContext context)
    {
        name = (string)info.GetValue("Name", typeof(string));
        maxH = (int)info.GetValue("Max Health", typeof(int));
         attack = (int)info.GetValue("Attack", typeof(int));
        defense = (int)info.GetValue("Defense", typeof(int));
        agility= (int)info.GetValue("Agility", typeof(int));
    }

    public BaseHero(string name, int maxH, int defense, int attack, int agility)
    {
        Name = name;
        Health = maxH;
        Defense = defense;
        Attack = attack;
        Agility = agility;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Any(char.IsDigit))
            {
                name = "";
            }
            name = value;
        }
    }
    public int Defense
    {
        get { return defense; }
        set
        {
            if (value > 50)
            {
                defense = 0;
            }
            defense = value;
        }
    }

    public int Attack
    {
        get { return attack; }
        set
        {
            if (value > 75)
            {
                attack = 0;
            }
            attack = value;
        }
    }
    public int Agility
    {
        get { return agility; }
        set
        {
            if (value > 50)
            {
                agility = 0;
            }
            agility = value;
        }
    }
    public int Health
    {
        get { return maxH; }
        set
        {
            if (value < 500)
            {
                maxH = 0;
            }
            maxH = value;
        }
    }

}



