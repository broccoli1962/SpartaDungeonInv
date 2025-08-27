using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public float Gold { get; private set; }
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float Hp { get; private set; }
    public float Crit { get; private set; }

    public Character(string name, int level, float gold, float atk, float def, float hp, float crit)
    {
        Name = name;
        Level = level;
        Gold = gold;
        Atk = atk;
        Def = def;
        Hp = hp;
        Crit = crit;
    }
}
