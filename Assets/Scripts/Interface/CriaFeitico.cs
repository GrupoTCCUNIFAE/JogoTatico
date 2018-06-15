using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaFeitico : MonoBehaviour {

	public GameObject speelPanel;
	public GameObject canvas;

	private string speel;

	public void LerAcoes(){
		speel = "003(85)(0)(103)";
		for(int i =0;i<speelPanel.transform.childCount; i++){
			Transform trans = speelPanel.transform.GetChild(i);
			if (trans.GetComponentInChildren< DragAndDropItem> () != null) {
				speel += ";" + trans.GetComponentInChildren< DragAndDropItem> ().action;
				GameObject des = trans.GetChild(0).gameObject;
				Destroy (des);
			}
			
		}
		PlayerPrefs.SetString ("FeiticoSlot0", speel);
		canvas.SetActive (false);
	}
}
