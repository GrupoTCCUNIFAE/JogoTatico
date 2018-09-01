using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour {

	public GameObject cardMeio, cardEsquerda, cardDireita;

	private int cardAtual = 0;
	private Text cardMeioText, cardEsquerdaText, cardDireitaText;
	private Image cardMeioSprite, cardEsquerdaSprite, cardDireitaSprite;
	private Inventario inventario;

	void Start () {
		cardMeioText = cardMeio.GetComponentInChildren<Text> ();
		cardDireitaText = cardDireita.GetComponentInChildren<Text> ();
		cardEsquerdaText = cardEsquerda.GetComponentInChildren<Text> ();
		cardMeioSprite = cardMeio.transform.GetComponentsInChildren<Image> ()[2];
		cardDireitaSprite = cardDireita.transform.GetComponentsInChildren<Image> ()[2];
		cardEsquerdaSprite = cardEsquerda.transform.GetComponentsInChildren<Image> ()[2];
		inventario = PlayerManager.instance.GetComponent<Inventario> ();

		Itens.CarregarCards ();
	}

	void Update () {
		MontaCardEsquerda (cardAtual - 1);
		MontaCardMeio (cardAtual);
		MontaCardDireita (cardAtual + 1);
	}

	private void MontaCardMeio(int id){
		if (id >= 0 && id < inventario.Cards.Count) {
			cardMeio.SetActive (true);
			Card card = Itens.card [inventario.Cards [id]];
			cardMeioSprite.sprite = card.Imagem;
			cardMeioText.text = MontaTexto(card);
		} else {
			cardMeio.SetActive (false);
		}
	}
	private void MontaCardEsquerda(int id){
		if (id >= 0 && id < inventario.Cards.Count) {
			cardEsquerda.SetActive (true);
			Card card = Itens.card [inventario.Cards [id]];
			cardEsquerdaSprite.sprite = card.Imagem;
			cardEsquerdaText.text = MontaTexto(card);
		} else {
			cardEsquerda.SetActive (false);
		}
	}
	private void MontaCardDireita(int id){
		if (id >= 0 && id < inventario.Cards.Count) {
			cardDireita.SetActive (true);
			Card card = Itens.card [inventario.Cards [id]];
			cardDireitaSprite.sprite = card.Imagem;
			cardDireitaText.text = MontaTexto(card);
		} else {
			cardDireita.SetActive (false);
		}
	}

	public void Proximo(){
		if(cardAtual < inventario.Cards.Count)
			cardAtual += 1;
	}

	public void Anterior(){
		if(cardAtual > 0)
			cardAtual -= 1;
	}

	private string MontaTexto(Card card){
		StringBuilder builder = new StringBuilder ();

		builder.Append (card.Nome).Append("\n");
		builder.Append ("Tipo de dano: ").Append (card.TipoDano).Append ("\n");
		builder.Append ("Dano: ").Append (card.Ataque).Append ("\n");
		builder.Append ("Defesa: ").Append (card.Defesa).Append("\n");
		builder.Append ("Resistencias: ");
		foreach (EnumElementos elemento in card.Resistencias) {
			builder.Append (elemento).Append(", ");
		}
		builder.Remove (builder.Length-2, 2);
		builder.Append ("\n");

		builder.Append ("Fraquesas: ");
		foreach (EnumElementos elemento in card.Fraquesas) {
			builder.Append (elemento).Append(", ");
		}
		builder.Remove (builder.Length-2, 2);

		return builder.ToString ();
	}

}
