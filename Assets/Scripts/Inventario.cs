using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour {

	private List<int> itens = new List<int>();
	private Item armadura;
	private Item arma;

	public List<int> Itens{
		get{return itens;}
	}

	public bool AdicionarItem(int id){
		itens.Add (id);
		return true;
	}
}
