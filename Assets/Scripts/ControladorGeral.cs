using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorGeral : MonoBehaviour {

	public float vida = 100f;
	public float mana = 100f;
	public float ataque = 10f;
	public float defesa = 100f;
	public float armadura = 0f;
    private int[] resistencias = new int[15];

	public float Vida{
		get{ return vida; }
		set{
			if (value < 0) {
				vida = 0;
				SceneManager.LoadScene(4);
			}
			else
				vida = value;
		}
	}
    public float Mana{
		get{ return mana; }
		set{mana = value; }
	}
    public float Defesa{
        get { return defesa; }
    }
    public float Armadura{
        get { return armadura; }
    }
    public int[] Resistencia{
        get { return resistencias;}
    }
	public float Ataque{
		get{return ataque;}
	}
}
