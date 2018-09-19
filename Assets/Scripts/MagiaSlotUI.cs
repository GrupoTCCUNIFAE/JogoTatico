using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagiaSlotUI : MonoBehaviour {

	public int slot;

	private Inventario inventario;

	void Start(){
		inventario = PlayerManager.instance.GetComponent<Inventario> ();
	}

	void Update(){
		if (transform.childCount > 2) {
			print (slot);
			inventario.MagiasPreparadas [slot] = transform.GetComponentsInChildren<MagiaItemUI>()[0].id;
		}
	}

}
