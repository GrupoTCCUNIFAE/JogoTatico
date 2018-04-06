using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoJogador : MonoBehaviour {

	public Camera cam;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = cam.ScreenPointToRay (Input.mousePosition);
		Debug.DrawLine (ray.origin, ray.direction);

		if (Physics.Raycast(ray, out hit)){
			transform.LookAt (new Vector3(hit.point.x, transform.position.y, hit.point.z));
		}
	}
}
