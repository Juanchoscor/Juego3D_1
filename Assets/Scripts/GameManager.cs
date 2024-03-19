using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Puntaje Total
    public int puntos;

    // Número de intentos
    public int intentos;

    // Texto que muestra los puntos
    public Text textoPuntos;

    // Texto que muestra los intentos
    public Text textoIntentos;

    // Texto que muestra el puntaje obtenido en la pantalla "Try Again"
    public Text textoPuntajeTryAgain;

    void Start()
    {

        // Recuperar el puntaje guardado en PlayerPrefs
      {
        int puntajeObtenido = PlayerPrefs.GetInt("", 0);

        // Mostrar el puntaje obtenido en la pantalla "Try Again"
        textoPuntajeTryAgain.text = "" + puntajeObtenido.ToString();
      }
        // Inicializar los puntos e intentos
        puntos = 0;
        intentos = 5; // Puedes ajustar el número de intentos inicial según sea necesario
        ActualizarTextoPuntos();
        ActualizarTextoIntentos();
    }

    // Restar un intento
    public void restarIntentos(int intentosR)
    {
        intentos -= intentosR;
        ActualizarTextoIntentos();

        // Verificar si los intentos llegan a cero
        if (intentos <= -1)
        {
            CargarEscenaRestart();
        }
    }

    // Sumar puntos
    public void sumarPuntos(int puntaje)
    {
        puntos += puntaje;
        ActualizarTextoPuntos();
    }

    // Cargar la escena principal
    public void CargarEscenaPrincipal()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Cargar la escena de resumen
    void CargarEscenaRestart()
    {
            // Guardar el puntaje antes de cargar la escena de resumen
        PlayerPrefs.SetInt("", puntos);
        PlayerPrefs.Save();

        SceneManager.LoadScene("ResumenScene");
        SceneManager.LoadScene("RestartScene");
    }

    // Actualizar el texto del puntaje
    void ActualizarTextoPuntos()
    {
        textoPuntos.text = "" + puntos.ToString();
    }

    // Actualizar el texto de los intentos
    void ActualizarTextoIntentos()
    {
        textoIntentos.text = "" + intentos.ToString();
    }
}
