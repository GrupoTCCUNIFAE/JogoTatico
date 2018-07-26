using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

/* Controls the player. Here we chose our "focus" and where to move. */

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {
	public GameObject criadorDeFeiticos;
	public LayerMask movementMask;		// The ground
	public Camera cam;

	private GameObject inventario;

	PlayerMotor motor;		// Reference to our motor

	// Get references
	void Start (){
		motor = GetComponent<PlayerMotor>();
		inventario = GetComponent<InterfaceManager> ().inventarioUI.gameObject;
	}

	// Update is called once per frame
	void Update (){

		// If we press left mouse
		if (Input.GetMouseButton(0) && !criadorDeFeiticos.activeSelf && !inventario.activeInHierarchy){
			// Shoot out a ray
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			// If we hit
			if (Physics.Raycast(ray, out hit, movementMask)){
				motor.MoveToPoint(hit.point);

			}
		}

	}

}