using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaFeitico : MonoBehaviour {

	public GameObject spellPanel;
	public GameObject canvas;
	public MagiasUI magias;

	private string spell;
	private int slot;

	public void LerAcoes(){
		spell = "";
		Inventario inv = PlayerManager.instance.GetComponent<Inventario> ();

		inv.MagiasPreparadas [slot] = magias.Magia;

		for(int i =0;i<spellPanel.transform.childCount; i++){
			Transform trans = spellPanel.transform.GetChild(i);
			if (trans.GetComponentInChildren< DragAndDropItem> () != null) {
				spell += trans.GetComponentInChildren< DragAndDropItem> ().action+";";
				GameObject des = trans.GetChild(0).gameObject;
				Destroy (des);
			}
			
		}
		spell = spell.Substring (0, spell.Length - 1);
		PlayerPrefs.SetString ("FeiticoSlot"+slot, spell);
		canvas.SetActive (false);
	}

	public int Slot{
		set{ slot = value; }
		get{ return slot; }
	}
}
