using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFixa : MonoBehaviour {

	public int velocidadeDoZoom;
	public int limiteParaPerto;
	public int limiteParaLonge;

	void Update () {
		if (Input.mouseScrollDelta.y > 0) {
			if(transform.position.y <= limiteParaLonge)
				transform.position = new Vector3 (transform.position.x, transform.position.y+velocidadeDoZoom*Time.deltaTime, transform.position.z-velocidadeDoZoom*Time.deltaTime);
		}
		if (Input.mouseScrollDelta.y < 0) {
			if(transform.position.y >= limiteParaPerto)
				transform.position = new Vector3 (transform.position.x, transform.position.y-velocidadeDoZoom*Time.deltaTime, transform.position.z+velocidadeDoZoom*Time.deltaTime);
		}
	}
}
