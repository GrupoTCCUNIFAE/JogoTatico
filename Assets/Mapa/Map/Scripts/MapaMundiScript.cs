using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapaMundiScript : MonoBehaviour {

	public GameObject image;
	public GameObject MiniMap;
	public GameObject MapaMundi;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Map")) {
			Desativar();
		}

	}


	public void Desativar(){
		if (image.gameObject.activeInHierarchy == true) {
			image.gameObject.SetActive (false);
		} else {
			image.gameObject.SetActive (true);
		}

		if(MiniMap.gameObject.activeInHierarchy == true){
			MiniMap.gameObject.SetActive (false);
		}else{
			MiniMap.gameObject.SetActive (true);
		}

		if(MapaMundi.gameObject.activeInHierarchy == true){
			MapaMundi.gameObject.SetActive (false);
		}else{
			MapaMundi.gameObject.SetActive (true);
		}
	}




}