using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {

    private PotionTypes potionType;

    public enum PotionTypes
    {
        HEALTH,
        MANA,
        STRENGTH,
        DEXTERITY,
        INTELLIGENCE,
        CONSTITUTION
    }

    public PotionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }
    }
}
