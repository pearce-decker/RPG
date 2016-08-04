using UnityEngine;
using System.Collections;

public class BaseCharacterClass {
    private string className;
    private string classDescription;
    private int strength;
    private int dexterity;
    private int intelligence;
    private int constitution;

    public string ClassName
    {
        get { return className; }
        set { className = value; }
    }
    public string ClassDescription
    {
        get { return classDescription; }
        set { classDescription = value; }
    }

    //stats
    public int Strength {
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
