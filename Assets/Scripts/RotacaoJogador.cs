using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoJogador : MonoBehaviour {

	public Camera cam;

	private RaycastHit hit;
	private Ray ray;

	void Update () {
		ray = cam.ScreenPointToRay (Input.mousePosition);

		if (Physics.Raycast(ray, out hit)){
			transform.LookAt (new Vector3(hit.point.x, transform.position.y, hit.point.z));
		}
	}

	public Vector3 localDaMagia(){
		ray = cam.ScreenPointToRay (Input.mousePosition);

		if (Physics.Raycast(ray, out hit)){
			return hit.point;
		}
		return Vector3.zero;
	}
}
