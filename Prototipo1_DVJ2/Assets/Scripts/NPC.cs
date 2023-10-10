using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour{
    public AudioSource sonido;
    public AudioClip npcSound;
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
                    sonido.PlayOneShot(npcSound);
                    break;
                }
                case 2:{
                    sonido.PlayOneShot(npcSound);
                    //pantalla final
                    break;
                }
            }
        }
    }
}