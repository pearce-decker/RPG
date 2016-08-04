using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem {
    private int strength;
    private int dexterity;
    private int intelligence;
    private int constitution;

    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }
    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }
    public int Constitution
    {
        get { return constitution; }
        set { constitution = value; }
    }

}
