using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    [SerializeField]public int salmon;

    // Start is called before the first frame update
    void Start(){
        salmon=0;
    }

    // Update is called once per frame
    void Update(){
    }
    public void RecolectarSalmon(){
        salmon++;
    }
}