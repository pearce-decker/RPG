using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass
{

    public BaseMageClass()
    {
        ClassName = "Mage";
        ClassDescription = "A mystical master who has low strength but very high intelligence";
        Strength = 8;
        Dexterity = 10;
        Constitution = 12;
        Intelligence = 18;
    }
}
