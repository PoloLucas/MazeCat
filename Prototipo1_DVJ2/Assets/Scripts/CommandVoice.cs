using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class CommandVoice : MonoBehaviour{
    // Start is called before the first frame update
    KeywordRecognizer keywordRecognizer; // creo mi reconocedor de comandode voz
    Dictionary<string, Action> actions = new Dictionary<string, Action>(); // creo las comando
    private Vector3 direccion;
    private float velocidad;

    void Start(){
        //creo las acciones segun el comandod e voz
        actions.Add("up",MoverArriba);
        actions.Add("down",MoverAbajo);
        actions.Add("left",MoverIzquierda);
        actions.Add("right",MoverDerecha);
        actions.Add("stop",Parar);
        actions.Add("arriba",MoverArriba);
        actions.Add("abajo",MoverAbajo);
        actions.Add("izquierda",MoverIzquierda);
        actions.Add("derecha",MoverDerecha);
        actions.Add("para",Parar);
        //seteo el ronocedor de voz y lo inicio
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
        velocidad=1;
    }

    void Update(){
        transform.Translate(direccion);
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs command){
        actions[command.text].Invoke();
    }

    private void MoverArriba(){
        Debug.Log("ARRIBA");
        direccion=new Vector3(0,0,velocidad*Time.deltaTime);
    }

    private void MoverAbajo(){
        Debug.Log("ABAJO");
        direccion=new Vector3(0,0,-(velocidad*Time.deltaTime));
    }

    private void MoverIzquierda(){
        Debug.Log("IZQUIERDA");
        direccion=new Vector3(-(velocidad*Time.deltaTime),0,0);
    }

    private void MoverDerecha(){
        Debug.Log("DERECHA");
        direccion=new Vector3(velocidad*Time.deltaTime,0,0);
    }

    private void Parar(){
        Debug.Log("PARAR");
        direccion=new Vector3(0,0,0);
    }
}