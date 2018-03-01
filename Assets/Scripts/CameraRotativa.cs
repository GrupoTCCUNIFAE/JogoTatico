using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotativa : MonoBehaviour {

	public Transform centroDaCamera;
	public int velocidadeDeRotacao;
	public int pontoDeRolagem;

	void Update () {
		Vector3 rotacaoCentro = centroDaCamera.rotation.eulerAngles;

		if(Input.mousePosition.x < pontoDeRolagem){
			centroDaCamera.rotation = Quaternion.Euler (new Vector3 (rotacaoCentro.x, rotacaoCentro.y+velocidadeDeRotacao*Time.deltaTime, rotacaoCentro.z));
		}
		if(Input.mousePosition.x > Screen.width-pontoDeRolagem){
			centroDaCamera.rotation = Quaternion.Euler (new Vector3 (rotacaoCentro.x, rotacaoCentro.y-velocidadeDeRotacao*Time.deltaTime, rotacaoCentro.z));
		}
	}
}
