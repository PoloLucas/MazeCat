using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    [SerializeField]private int vidas=3;
    [SerializeField]public int salmon;

    // Start is called before the first frame update
    void Start(){
        salmon=0;
    }

    // Update is called once per frame
    void Update(){
        ComprobarVidas();
    }

    void ComprobarVidas(){
        if(vidas<=0){
            vidas=0;
            //fin del juego
        }
    }
}