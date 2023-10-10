using UnityEngine;
using System.Collections;

public class Salmon : MonoBehaviour {
    public AudioSource sonido;
    public AudioClip collectSound;
    private float rotationSpeed=10;
    public Player player;

    void Start(){
        player=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

	void Update (){
        transform.Rotate(new Vector3(0,0,10)*rotationSpeed*Time.deltaTime);
    }

    void OnTriggerEnter(Collider other){
        player.salmon++;
        gameObject.GetComponent<SphereCollider>().enabled=false;
        gameObject.GetComponent<MeshRenderer>().enabled=false;
        sonido.PlayOneShot(collectSound);
    }
}