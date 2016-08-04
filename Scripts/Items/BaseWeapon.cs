using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {

    private WeaponTypes weaponType;
    private int spellEffectID;

    public enum WeaponTypes
    {
        SWORD,
        DAGGER,
        BOW,
        STAFF,
        AXE,
        POLEARM
    }

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }

}
