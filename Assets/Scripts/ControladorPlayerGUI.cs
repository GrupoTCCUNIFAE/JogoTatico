using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPlayerGUI : MonoBehaviour {

	public ControladorGeral statusDoPlayer;
	public RectTransform barraDeVida;

	private float total;

	void Start(){
		total = barraDeVida.anchorMax.y - barraDeVida.anchorMin.y;
	}

	void Update () {
		barraDeVida.anchorMax = new Vector2 (barraDeVida.anchorMax.x, (((statusDoPlayer.Vida)/100)*total)+barraDeVida.anchorMin.y);
	}
}
