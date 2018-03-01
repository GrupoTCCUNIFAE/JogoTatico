using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPorArea : MonoBehaviour {

	public AreaDeCamera[] areas = new AreaDeCamera[0];

	private Camera cam;

	void Start () {
		cam = gameObject.GetComponent<Camera> ();
	}

	void Update () {
		if (vasculharAreas ())
			cam.enabled = true;
		else
			cam.enabled = false;
	}

	private bool vasculharAreas(){
		foreach (AreaDeCamera area in areas){
			if(area.playerDentro)
				return true;
		}
		return false;
	}
}
