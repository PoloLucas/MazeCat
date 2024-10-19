using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoVolumen : MonoBehaviour
{
  public Slider slider;
  public float sliderValue;
  public Image imagenMute;
  public Image imagenVolumen;
void start()
    {
    slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
    AudioListener.volume = slider.value;
    RevisarSiEstoyMute();
    }
   public void ChangeSlider(float valor){
    sliderValue = valor;
    PlayerPrefs.SetFloat("volumenAudio", sliderValue);
    AudioListener.volume = slider.value;
    RevisarSiEstoyMute();
}
 public void RevisarSiEstoyMute()
{
if (sliderValue == 0)
{
imagenMute.enabled = true;
imagenVolumen.enabled = false;
}
else{
imagenMute.enabled = false;
imagenVolumen.enabled = true;
 }
}
}