using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int puntos; //Puntaje Total
    public Text textoPuntos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sumarPuntos(int puntaje){
        puntos = puntos + puntaje;
        textoPuntos.text = puntos.ToString();
        
        
    }
}
