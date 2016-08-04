using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem {

    private EquipmentTypes equipmentType;
    private int spellEffectId;

    public enum EquipmentTypes
    {
        HEAD,
        CHEST,
        SHOULDERS,
        LEGS,
        FEET,
        NECK,
        RING1,
        RING2,
        HANDS
    }

    public EquipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

    public int SpellEffectId
    {
        get { return spellEffectId; }
        set { spellEffectId = value; }
    }

}
