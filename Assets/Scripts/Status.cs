﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour {

	public float vida = 100f;
	private float mana = 100f;
	private float ataque = 10f;

	public float Vida{
		get{return vida;}
		set{vida = value;}
	}
	public float Mana{
		get{return mana;}
	}
	public float Ataque{
		get{ return ataque;}
	}
}
