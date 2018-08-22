﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary; // bibilioteca para salvar em arquivo binario
using System.IO;

[Serializable]
public class PlayerData{
	public float vida;
	public float mana;
	public int arma;
	public int armadura;
	public List<int> itens;
	public List<int> magias;
	public int[] magiasPreparadas;
	public float xpNivel;
	public float xpNivelAnt;
	public float xpAtual;
	public int level;
}
