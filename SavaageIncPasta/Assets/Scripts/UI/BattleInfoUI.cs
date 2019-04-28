﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleInfoUI : MonoBehaviour
{
    public InventoryItem Item;

    public Text TextBox1;
    public Text TextBox2;
    public Text TextBox3;
    public Text TextBox4;
    public Text TextBox5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Item != null && Item.Item != null)
        {
            DisplayItem(Item);
        }
        else
        {
            Clear();
        }
	}

    void Clear()
    {
        TextBox1.text = "";
        TextBox2.text = "";
        TextBox3.text = "";
        TextBox4.text = "";
        TextBox5.text = "";
    }

    void DisplayItem(InventoryItem item)
    {
        TextBox1.text = item.Item.Name + "x" + item.Amount;
        TextBox2.text = item.Item.Description;
        switch (Item.Item.ItemType)
        {
            case ItemType.eCONSUMABLE:
                var consumable = (ConsumableItemData)Item.Item;
                TextBox3.text = consumable.ConsumableType.ToString().Remove(0, 1);
                TextBox4.text = "Effect = " + consumable.EffectAmount;
                break;
            case ItemType.eARMOUR:
                break;
            case ItemType.eWEAPON:
                break;
            default:
                break;
        }
    }
}