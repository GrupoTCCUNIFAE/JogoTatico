using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary; // bibilioteca para salvar em arquivo binario
using System.IO;

[Serializable]
public class PlayerData{
	public float vida;
	public float mana;
	public List<int> itens;

}
