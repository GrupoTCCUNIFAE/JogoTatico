using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagiasUI : MonoBehaviour {

	public Image imagemDaMagia;
	public Text nomeDaMagia;
	public Text danoDaMagia;
	public Text multiplicadorDeMana;

	private int magiaAtual = 0;
	private Inventario inventario;

	void Start(){
		Itens.CarregarMagias ();
		inventario = PlayerManager.instance.GetComponent<Inventario> ();
	}

	void Update(){
		imagemDaMagia.sprite = Itens.magia [inventario.Magias[magiaAtual]].Imagem;
		nomeDaMagia.text = Itens.magia [inventario.Magias[magiaAtual]].Nome;
		danoDaMagia.text = "Dano: "+Itens.magia [inventario.Magias[magiaAtual]].Dano;
		multiplicadorDeMana.text = "Multiplicador de Custo de mana: "+Itens.magia [inventario.Magias[magiaAtual]].MultiplicadorDeMana;
	}

	public void ProximaMagia(){
		if (magiaAtual < inventario.Magias.Count-1) {
			magiaAtual++;
		} else {
			magiaAtual = 0;
		}
	}

	public void MagiaAnterior(){
		if (magiaAtual > 0) {
			magiaAtual--;
		} else {
			magiaAtual = inventario.Magias.Count-1;
		}
	}

	public int Magia{
		get{ return magiaAtual; }
	}

}
