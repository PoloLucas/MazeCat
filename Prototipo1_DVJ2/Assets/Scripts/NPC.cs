using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour{
    [SerializeField] private GameObject door;
    [SerializeField] private int npcType=1;
    private Player player;
    private bool isActive=false;

    void Start(){
        player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        isActive=true;
    }

    void OnTriggerEnter(Collider other){
        if(player.salmon>=20 && isActive){
            isActive=false;
            switch(npcType){
                case 1:{
                    player.salmon=0;
                    door.SetActive(false);
                    break;
                }
                case 2:{
                    //pantalla final
                    break;
                }
            }
        }
    }
}