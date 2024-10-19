using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed=10;
    public PlayerInput input;
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
  void Update(){
        input = GetComponent<PlayerInput>();
        MoverGato(input.moveX,input.moveZ);
    }

    public void MoverGato(float moverLados, float moverAltura){
        Vector3 movement=new Vector3(moverLados,0,moverAltura).normalized;
        transform.Translate(movement*speed*Time.deltaTime);
    }
}
