using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : ControladorGeral {

	public int velocidadeDaMagia;

	private Inventario inventario;

	void Start () {
		inventario = PlayerManager.instance.GetComponent<Inventario> ();
		Controle controle = GetComponent<Controle> ();
		if (controle.Data != null) {
			vida = controle.Data.vida;
			mana = controle.Data.mana;
		} else {
			vida = 100;
			mana = 100;
		}
		AtualizarStatus ();
	}
	void Update () {
		AtualizarStatus ();
	}

	private void AtualizarStatus(){
		if (inventario.Armadura != -1) {
			armadura = Itens.item [inventario.Armadura].Defesa;
		}
		if (inventario.Arma != -1) {
			ataque = Itens.item [inventario.Arma].Ataque;
		}
	}
}
