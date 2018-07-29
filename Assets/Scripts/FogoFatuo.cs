using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FogoFatuo : MonoBehaviour {

	NavMeshAgent nav;

	void Start () {
		nav = GetComponent<NavMeshAgent> ();
	}

	void Update () {
		if (Vector3.Distance (transform.position, PlayerManager.instance.transform.position) > 3)
			nav.SetDestination (PlayerManager.instance.transform.position);
		else
			nav.SetDestination (transform.position);
	}
}
