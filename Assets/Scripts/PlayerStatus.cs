using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : ControladorGeral {

	private Inventario inventario;

	void Start () {
		inventario = PlayerManager.instance.GetComponent<Inventario> ();
		Controle controle = GetComponent<Controle> ();

		vida = controle.Data.vida;
		mana = controle.Data.mana;

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
