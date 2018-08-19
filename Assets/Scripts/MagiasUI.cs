using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagiasUI : MonoBehaviour {

	public GameObject magiaSlot;

	private ScrollRect scrollRect;
	private Inventario player;

	void Start () {
		scrollRect = GetComponent<ScrollRect> ();
		player = PlayerManager.instance.GetComponent<Inventario>();
		AtualizarInventario ();
	}
	

	public void AtualizarInventario(){
		
		for (int cnt = 0; cnt < scrollRect.content.transform.childCount; cnt++) {
			Destroy(scrollRect.content.transform.GetChild (cnt).gameObject);
		}

		foreach(int idDaMagia in player.Magias){
			Magia magia = Itens.magia [idDaMagia];
			GameObject novaMagia = Instantiate (magiaSlot, Vector3.zero, Quaternion.identity);
			novaMagia.name = "Magia";
			Image imagem = novaMagia.transform.GetChild(0).GetComponent<Image> ();

			novaMagia.GetComponentInChildren<MagiaItemUI> ().id = idDaMagia;
			imagem.sprite = magia.Imagem;

			imagem.enabled = true;
			novaMagia.GetComponent<Image> ().enabled = true;

			novaMagia.transform.SetParent (scrollRect.content);
		} 
	}
}
