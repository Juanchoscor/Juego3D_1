using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool onGround;
    public float fuerza_y;
    public float fuerza_z;
    public Vector3 posicionInicial;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        onGround = false;
        fuerza_y=0;
        fuerza_z=0;
        posicionInicial=this.transform.position;
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("Este objeto no tiene un Rigidbody adjunto.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onGround){
                Vector3 fuerza = new Vector3(0,fuerza_y,fuerza_z);
                GetComponent<Rigidbody>().AddForce(fuerza);
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            fuerza_y = fuerza_y -100;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            fuerza_y = fuerza_y +100;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            fuerza_z = fuerza_z -100;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            fuerza_z = fuerza_z +100;
        }
         if (Input.GetKeyDown(KeyCode.R))
        {
            this.transform.position = posicionInicial;
            Detener();
        }

    }

    void Detener()
    {
        rb.velocity = Vector3.zero;
    }

    private void OnCollisionEnter(Collision c){
        Debug.Log("Colision");
        onGround = true;
    }
    private void OnCollisionStay(Collision c){

        onGround = true;
    }
    private void OnCollisionExit(Collision c){
        onGround = false;
        Debug.Log("Libre");
    }
}
