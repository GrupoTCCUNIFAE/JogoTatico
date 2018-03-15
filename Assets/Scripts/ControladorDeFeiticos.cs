using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeFeiticos : MonoBehaviour {

	public Feitico[] feiticos = new Feitico[0];

	void Update()
	{
		foreach (Feitico feitico in feiticos) {
			if (feitico != null) {
				feitico.Update ();
			}
		}
	}
}