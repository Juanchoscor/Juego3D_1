using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    // Start is called before the first frame update
    public int puntaje; //Puntos que da el cubo
    public int intentosR; //Intentos que resta

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Restar intento");
            GameObject.Find("GameManager").GetComponent<GameManager>().restarIntentos(intentosR);
        }
    }

    private void OnTriggerEnter(Collider c)
    {
        Debug.Log("Choque tipo trigger");
        GameObject.Find("GameManager").GetComponent<GameManager>().sumarPuntos(puntaje);
    }
}
