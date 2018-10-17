using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorGeral : MonoBehaviour {

	public float vida = 100f;
	public float mana = 100f;
	public float ataque = 2f;
	public float defesa = 100f;
	public float armadura = 0f;
	public EnumElementos[] resistencias = new EnumElementos[15];
	public EnumElementos[] fraquezas = new EnumElementos[15];
    private EnumElementos elemento;

    public float Vida{
		get{ return vida; }
		set{
			if (value < 0) {
				vida = 0;
				Destroy (gameObject);
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
    public EnumElementos[] Resistencia{
        get { return resistencias; }
    }
    public EnumElementos[] Fraquezas{
        get { return fraquezas; }
    }
	public float Ataque{
		get{return ataque;}
		set{ataque = value;}
	}
    public EnumElementos Elemento{
        get { return elemento; }
    }

}
