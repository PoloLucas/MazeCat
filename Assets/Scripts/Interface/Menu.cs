using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public void EmpezarNivel(string NombreNivel)
    {
        SceneManager.LoadScene(NombreNivel);
    }

    public void Salir()
    {
        Application.Quit();
    }

}
