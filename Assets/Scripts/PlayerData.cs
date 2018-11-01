using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary; // bibilioteca para salvar em arquivo binario
using System.IO;

[Serializable]
public class PlayerData{
	public float vida;
	public float vidaMaxima;
	public float mana;
	public float manaMaxima;
	public int arma;
	public int armadura;
	public List<int> itens;
	public List<int> magias;
	public List<int> cards;
	public int[] magiasPreparadas;
	public float xpAtual;
	public int level;
	public int velocidade;
	public int artefato;
}
