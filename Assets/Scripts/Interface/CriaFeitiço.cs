using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaFeitiço : MonoBehaviour {

	public GameObject speelPanel;
	public string speel;

	void Start(){



	}

	public void LerAcoes(){
		Debug.Log ("teste");

		for(int i =0;i<speelPanel.transform.childCount; i++){

			Transform trans = speelPanel.transform.GetChild(i).GetChild(0);
			Debug.Log(trans.GetComponent< DragAndDropItem>().action);

			speel += trans.GetComponent< DragAndDropItem>().action + "-";



		}
		Debug.Log (speel);
		speel ="-";




	}




}
