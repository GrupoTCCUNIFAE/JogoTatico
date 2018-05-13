using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFixa : MonoBehaviour {

	public int velocidadeDoZoom;
	public Transform player;

	void Update () {
		transform.position = new Vector3 (player.position.x, transform.position.y, player.position.z);

		if (Input.mouseScrollDelta.y > 0) {
			GetComponent<Camera> ().orthographicSize -= velocidadeDoZoom;
		}
		if (Input.mouseScrollDelta.y < 0) {
			GetComponent<Camera> ().orthographicSize += velocidadeDoZoom;
		}
	}
}
