using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControle : MonoBehaviour {

	Controle controle;

	public Text vida, mana;


	// Use this for initialization
	void Start () {
		controle = Controle.controle;
	}

	public void Salvar(){
		controle.Salvar ();	
	}

	public void Carregar(){
		controle.Carregar ();
		UpdateUI ();
	}
		

	void UpdateUI(){
		//vida.text = "Vida: " + controle.GetVida ().ToString ();
		//mana.text = "Mana: " + controle.GetMana ().ToString ();
	}
}
