using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : ControladorGeral{

	private int velocidadeDaMagia = 5;
	public  ControladorXp xp;
	private Inventario inventario;
	private float vidaMaxima;
	private float manaMaxima;

	void Start () {
		inventario = PlayerManager.instance.GetComponent<Inventario> ();
		Controle controle = GetComponent<Controle> ();
		if (controle.Data != null) {
			vida = controle.Data.vida;
			mana = controle.Data.mana;
			vidaMaxima = controle.Data.vidaMaxima;
			manaMaxima = controle.Data.manaMaxima;
			velocidadeDaMagia = controle.Data.velocidade;
			xp = new ControladorXp (controle.Data.xpAtual, controle.Data.level);
		} else {
			xp = new ControladorXp (0, 1);
			vida = 100;
			mana = 100;
			vidaMaxima = 100;
			manaMaxima = 100;
		}
		AtualizarStatus ();
	}
	void Update () {
		AtualizarStatus ();
	}

	private void AtualizarStatus(){
		if (inventario.Armadura != -1) {
			armadura = Itens.item [inventario.Armadura].Defesa;
		} else {
			armadura = 0;
		}
		if (inventario.Arma != -1) {
			ataque = Itens.item [inventario.Arma].Ataque;
		} else {
			ataque = 1;
		}
	}

	public float Vida {
		set{ 
			if (value <= vidaMaxima)
				vida = value;
			else
				vida = vidaMaxima;

			if (value < 0) {
				vida = vidaMaxima;
				Destroy (gameObject);
			}			
		}
		get{return vida;}
	}

	public float Mana {
		set{ 
			if (value <= manaMaxima)
				mana = value;
			else
				mana = manaMaxima;
		}
		get{return mana;}
	}

	public float VidaMaxima{
		set{ 
			vidaMaxima = value; 
			vida = vidaMaxima;
		}
		get{ return vidaMaxima; }
	}

	public float ManaMaxima{
		set{ 
			manaMaxima = value; 
			mana = manaMaxima;
		}
		get{ return manaMaxima; }
	}

	public int Velocidade{
		set{ velocidadeDaMagia = value; }
		get{ return velocidadeDaMagia; }
	}
}
