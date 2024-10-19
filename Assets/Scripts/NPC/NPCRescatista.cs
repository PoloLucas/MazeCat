using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NPCRescatista : NPCType
{
    public override void Interactuar(){
        sonido.PlayOneShot(npcSound);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
