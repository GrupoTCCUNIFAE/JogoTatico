﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeMagiasUI : MonoBehaviour {

	private Inventario inventario;

	void Start () {
		inventario = PlayerManager.instance.GetComponent<Inventario> ();
		AtualizarBarra ();
	}
	void Update(){
		AtualizarBarra ();
	}
	public void AtualizarBarra () {		
		for (int cnt = 0; cnt < transform.GetChild(0).childCount; cnt++) {
			if (inventario.MagiasPreparadas [cnt] != -1) {
				transform.GetChild(0).GetChild (cnt).GetComponentsInChildren<Image> () [1].color = Color.white;
				transform.GetChild(0).GetChild (cnt).GetComponentsInChildren<Image> () [1].sprite = Itens.magia [inventario.MagiasPreparadas [cnt]].Imagem;
			} else {
				transform.GetChild(0).GetChild (cnt).GetComponentsInChildren<Image> () [1].color = Color.clear;
			}
		}
	}
}
