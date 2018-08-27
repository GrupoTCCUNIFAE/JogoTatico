using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonstronomiconUI : MonoBehaviour {
	/*
	public GameObject cardSlot;
	public GameObject info;

	private Inventario player;
	private ScrollRect scrollRect;

	void Start () {
		Itens.CarregarCards ();
		player = PlayerManager.instance.GetComponent<Inventario>();
		scrollRect = GetComponent<ScrollRect> ();
		AtualizarLivro ();
		//transform.parent.parent.gameObject.SetActive (false);
	}

	void AtualizarLivro () {
		for (int cnt = 0; cnt < scrollRect.content.transform.childCount; cnt++) {
			Destroy(scrollRect.content.transform.GetChild (cnt).gameObject);
		}

		foreach(int idDaCarta in player.Cartas){
			Card item = Itens.card [idDaCarta];
			GameObject novoCard = Instantiate (cardSlot, Vector3.zero, Quaternion.identity);
			novoCard.name = "Card do Inventario";
			Image imagem = novoCard.transform.GetChild(0).GetComponent<Image> ();
			Text texto = novoCard.transform.GetChild (1).GetComponent<Text> ();

			novoCard.GetComponent<ItemUI> ().id = idDaCarta;
			novoCard.GetComponent<ItemUI> ().info = info;
			imagem.sprite = item.Imagem;
			texto.text = item.Nome;

			novoCard.transform.SetParent (scrollRect.content);
		} 
	}*/
}
