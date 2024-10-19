using UnityEngine;
using System.Collections;

public class SalmonHarvest : MonoBehaviour {
    public AudioSource sonido;
    public AudioClip collectSound;
    public Player player;

    void Start(){
        player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
	void Update (){
    }
       void OnTriggerEnter(Collider other){
        player.RecolectarSalmon();
        gameObject.GetComponent<SphereCollider>().enabled=false;
        gameObject.GetComponent<MeshRenderer>().enabled=false;
        sonido.PlayOneShot(collectSound);
    }
}