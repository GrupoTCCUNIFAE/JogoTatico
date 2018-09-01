using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPlayerGUI : MonoBehaviour {

	public ControladorGeral statusDoPlayer;
	public RectTransform barraDeMana;
	public RectTransform barraDeVida;

	private float total;

	void Start(){
		total = barraDeMana.anchorMax.y - barraDeMana.anchorMin.y;
	}

	void Update () {
		barraDeMana.anchorMax = new Vector2 (barraDeMana.anchorMax.x, (((statusDoPlayer.Mana)/100)*total)+barraDeMana.anchorMin.y);
		barraDeVida.anchorMax = new Vector2 (barraDeVida.anchorMax.x, (((statusDoPlayer.Vida)/100)*total)+barraDeVida.anchorMin.y);
	}
}
