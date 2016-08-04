using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

    public BaseWarriorClass()
    {
        ClassName = "Warrior";
        ClassDescription = "A skilled martial fighter with high strength and constitution";
        Strength = 18;
        Dexterity = 10;
        Constitution = 16;
        Intelligence = 8;
    }
}
