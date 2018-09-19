using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPlayerGUI : MonoBehaviour {

	public PlayerStatus statusDoPlayer;
	public RectTransform barraDeMana;
	public RectTransform barraDeVida;
	public Text level;

	private float total;

	void Start(){
		total = barraDeMana.anchorMax.y - barraDeMana.anchorMin.y;
	}

	void Update () {
		level.text = "Level: " + statusDoPlayer.xp.Level;
		barraDeMana.anchorMax = new Vector2 (barraDeMana.anchorMax.x, (((statusDoPlayer.Mana)/statusDoPlayer.ManaMaxima)*total)+barraDeMana.anchorMin.y);
		barraDeVida.anchorMax = new Vector2 (barraDeVida.anchorMax.x, (((statusDoPlayer.Vida)/statusDoPlayer.VidaMaxima)*total)+barraDeVida.anchorMin.y);
	}
}
