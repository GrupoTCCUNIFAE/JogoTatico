using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPerspectiva : MonoBehaviour {

	public Transform player;

	void Update () {
		transform.position = new Vector3 (player.position.x, transform.position.y, player.position.z);
	}
}
