﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour {

	private float vida = 100f;
	private float mana = 100f;
    private float defesa = 100f;
    private float armadura = 100f;
    private int[] resistencias = new int[15];

	public float Vida{
		get{ return vida; }
	}
    public float Mana{
		get{ return mana; }
	}
    public float Defesa{
        get { return defesa; }
    }
    public float Armadura{
        get { return armadura; }
    }
    public int Resistencia{
        get { return resistencias[]; }
    }



}
