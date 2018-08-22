using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorXp : MonoBehaviour{


	private float xpNivel = 40;
	private float xpNivelAnt = 40;
	private float xpAtual = 0;
	private int level = 1;
	private float percentual= 0.20f;

	public void Evoluir(){
		float aux = 0;

		level = level + 1;
		aux = xpNivel;
		xpNivel = (xpNivel + xpNivelAnt) -  percentual *(xpNivel + xpNivelAnt);
		XpNivelAnt = aux;
		aumentarStatus ();

	}

	public float XpAtual{
		get{ return xpAtual; }
		set{
			float aux = xpAtual + value;
			if (xpNivel <= aux) {
				aux = aux - xpAtual; 
				xpAtual = value;
				Evoluir();
			} else {
				xpAtual = value;
			}

		}
	}


	public void aumentarStatus(){
		PlayerStatus jogador  = PlayerManager.instance.GetComponent<PlayerStatus>();

		jogador.Vida = jogador.Vida + 10;
		jogador.Mana = jogador.Mana + 8;

	}

	public ControladorXp(float xpNivel){
		this.xpNivel = xpNivel;
	}

	public float XpNivel{
		get{ return xpNivel; }
		set{xpNivel = value; }
	}

	public float XpNivelAnt{
		get{ return xpNivelAnt; }
		set{xpNivelAnt = value; }
	}


	public int Level{
		get{ return level; }
		set{level = value; }
	}




}
