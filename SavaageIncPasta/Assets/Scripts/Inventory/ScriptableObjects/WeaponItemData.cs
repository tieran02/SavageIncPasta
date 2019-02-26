﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Data", menuName = "Items/WeaponItem", order = 1)]
public class WeaponItemData : BaseItemData
{
    public enum Type
    {
        eSWORD,
        eBOW,
        eSTAFF
    }

    public enum StatTypes
    {
        eNONE,
        eSTRENGTH,
        eAGILTITY
    }

    public WeaponItemData()
    {
        base._itemType = ItemType.eWEAPON;
    }

    [SerializeField]
    private Type _weaponType;
    [SerializeField]
    private StatTypes statType;
    [SerializeField]
    private float _minDamage;
    [SerializeField]
    private float _maxDamage;
    [SerializeField]
    private float _missFire;
    [SerializeField]
    private bool _isMelee;
    [SerializeField]
    private bool _isMainHand;

    public Type WeaponType
    {
        get { return _weaponType; }
    }

    public StatTypes StatType
    {
        get { return statType; }
    }

    public float MinDamage
    {
        get { return _minDamage; }
    }

    public float MaxDamage
    {
        get { return _maxDamage; }
    }

    public float MissFire
    {
        get { return _missFire; }
    }

    public bool IsMelee
    {
        get { return _isMelee; }
        set { _isMelee = value; }
    }

    public bool IsMainHand
    {
        get { return _isMainHand; }
    }
}