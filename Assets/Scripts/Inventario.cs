using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour {

	public MeshFilter armaduraMesh;
	public MeshFilter armaMesh;

	private List<int> itens;
	private int armadura = -1;
	private int arma = -1;
	private Controle controle;
	private Mesh playerSemArmadura;

	void Start(){
		playerSemArmadura = Resources.Load<Mesh> ("ItemModels/player_sem_armadura");
		Controle controle = PlayerManager.instance.GetComponent<Controle> ();
		if (controle.Data != null) {
			itens = controle.Data.itens;
			arma = controle.Data.arma;
			armadura = controle.Data.armadura;
		}
		else 
			itens = new List<int>();
	}

	void Update(){
		AtualizarVizual ();
	}

	private void AtualizarVizual(){
		if (armadura != -1)
			armaduraMesh.mesh = Itens.item [armadura].Modelo;
		else
			armaduraMesh.mesh = playerSemArmadura;

		if (arma != -1)
			armaMesh.mesh = Itens.item [arma].Modelo;
		else
			armaMesh.mesh = null;
	}

	public List<int> Bolsa{
		get{return itens;}
	}

	public bool AdicionarItem(int id){
		itens.Add (id);
		return true;
	}

	public int Armadura{
		get{return armadura;}
		set{
			if (value != -1) {
				if (armadura != -1) {
					itens.Add (armadura);
				}
				itens.Remove (value);
			} else {
				itens.Add (armadura);
			}

			armadura = value;
		}
	}

	public int Arma{
		get{return arma;}
		set{
			if (value != -1) {
				if (arma != -1) {
					itens.Add (arma);
				}
				itens.Remove (value);
			} else {
				itens.Add (arma);
			}

			arma = value;
		}
	}
}
