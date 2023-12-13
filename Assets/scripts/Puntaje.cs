using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public float _puntaje;
    public Text texto;
    public void puntajeConstante()
    {
        _puntaje = Random.Range(0, 5);
        texto.text = "Puntos: " + _puntaje.ToString();
    }

}
