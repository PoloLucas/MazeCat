using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float moveX;
    public float moveZ;
    void Update()
    {
        moveX=Input.GetAxis("Horizontal");
        moveZ=Input.GetAxis("Vertical");
    }
}
