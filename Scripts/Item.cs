﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private string itemName;
    private double weight;
    private double price;

    public string ItemName
    {
        get
        {
            return itemName;
        }
        set
        {
            itemName = value;
        }
    }

    public double Weight
    {
        get
        {
            return weight;
        }
        set
        {
            weight = value;
        }
    }

    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }

    public Item(string itemName, double weight, double price)
    {
        this.itemName = itemName;
        this.weight = weight;
        this.price = price;
    }
}
