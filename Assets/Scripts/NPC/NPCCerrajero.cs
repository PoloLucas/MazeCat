using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCerrajero : NPCType
{
    [SerializeField] private GameObject door;
    
    public override void Interactuar(){
        player.salmon=0;
        door.SetActive(false);
        sonido.PlayOneShot(npcSound);
    }
}

