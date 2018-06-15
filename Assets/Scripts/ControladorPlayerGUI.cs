using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPlayerGUI : MonoBehaviour {

	public ControladorGeral statusDoPlayer;
	public RectTransform barraDeVida;

	void Update () {
		//Total = 0.28
		barraDeVida.anchorMax = new Vector2 ((((statusDoPlayer.Vida)/100)*0.28f)+barraDeVida.anchorMin.x, barraDeVida.anchorMax.y);
	}
}
