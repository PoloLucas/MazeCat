using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public abstract class NPCType : MonoBehaviour{
    public AudioSource sonido;
    public AudioClip npcSound;
    public Player player;
    void Start(){
        player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    public abstract void Interactuar();
      void OnTriggerEnter(Collider other){
        if(player.salmon>=20){
        gameObject.GetComponent<CapsuleCollider>().enabled=false;
        Interactuar();
        }
    }
}

