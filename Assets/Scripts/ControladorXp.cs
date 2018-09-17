using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorXp{


	private float xpAtual = 0;
	private int levelAtual = 1;

	public ControladorXp(float xpAtual, int levelAtual){
		this.xpAtual = xpAtual;
		this.levelAtual = levelAtual;
	}

	public float XpAtual{
		get{ return xpAtual; }
		set{
			if (xpAtual > levelAtual * 1000) {
				levelAtual++;
				xpAtual = 0;
			}
			xpAtual = value;
		}
	}

	public int Level{
		get{ return levelAtual; }
		set{levelAtual++; }
	}
}
