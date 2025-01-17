using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CodigoMenuPausa : MonoBehaviour
{
    public GameObject MenuPausa;
    public bool Pausa = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Pausa == false)
            {
                MenuPausa.SetActive(true);
                Pausa = true;
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else if(Pausa == true)
            {
                Resumir();
            }
        }
        
    }
    public void Resumir()
    {
        MenuPausa.SetActive(false);
        Pausa = false;
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void CargarEscena(string NombreEscena)
    {
        SceneManager.LoadScene(NombreEscena);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
