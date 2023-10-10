using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehaviour : MonoBehaviour{
    public Player player;

    void Start(){
        player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        Destroy(gameObject,2);
    }

    void OnTriggerEnter(Collider other){
        //player.isLive=false;
    }
}