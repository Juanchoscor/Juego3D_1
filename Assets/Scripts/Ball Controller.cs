using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool onGround;
    public float fuerza_y;
    public float fuerza_x;
    // Start is called before the first frame update
    void Start()
    {
        onGround = false;
        fuerza_y=0;
        fuerza_x=0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Space key was released");
            if(GetComponent<Rigidbody>()!= null){
                GetComponent<Rigidbody>().useGravity=true;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (onGround){
                Vector3 fuerza = new Vector3(fuerza_x,1000,fuerza_y);
                GetComponent<Rigidbody>().AddForce(fuerza);
            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            fuerza_y = fuerza_y -10;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
          fuerza_y = fuerza_y +10;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            fuerza_x = fuerza_x -10;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
          fuerza_x = fuerza_x +10;
        }

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
