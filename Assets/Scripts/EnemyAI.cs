using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Handles interaction with the Enemy */

[RequireComponent(typeof(ControladorGeral))]
public class Enemy : Interactable
{

    PlayerManager playerManager;
    ControladorGeral myStats;


    void Start()
    {
        playerManager = PlayerManager.instance;
        myStats = GetComponent<ControladorGeral>();
    }

    public override void Interact()
    {
        base.Interact();
        CharacterCombat playerCombat = playerManager.player.GetComponent<CharacterCombat>();
        if (playerCombat != null)
        {
            playerCombat.Attack(myStats);
        }
    }

}