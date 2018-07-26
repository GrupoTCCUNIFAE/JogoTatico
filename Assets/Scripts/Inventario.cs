using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour {

	private List<int> itens;
	private int armadura = -1;
	private int arma = -1;
	private Controle controle;

	void Start(){
		Controle controle = PlayerManager.instance.GetComponent<Controle> ();
		if (controle.Data != null) {
			itens = controle.Data.itens;
			arma = controle.Data.arma;
			armadura = controle.Data.armadura;
		}
		else 
			itens = new List<int>();
	}

	public List<int> Itens{
		get{return itens;}
	}

	public bool AdicionarItem(int id){
		itens.Add (id);
		return true;
	}

	public int Armadura{
		get{return armadura;}
		set{armadura = value;}
	}

	public int Arma{
		get{return arma;}
		set{arma = value;}
	}
}
