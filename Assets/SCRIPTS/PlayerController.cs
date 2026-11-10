using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15f; //Speed at which the paddle moves
    public float topheight;
    public float botheight; //Bottom limit of the paddle's movement
    public float diferencia;
    public float IAFollowTolerance = 0.5f;
    public bool useArrowKeys = false; //if true, use arrow keys; if false, use W and S keys
    public GameObject ball;
    public bool IA;
    public int direccion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IA == false)
        {
        MovePaddle();

        }
        else 
        {
            MovePaddleIA();
        }


        
    }

    void MovePaddle()

    {
        this.gameObject.transform.position = new Vector3(transform.position.x, ConstrainPaddle(), transform.position.z);

    }


    float ConstrainPaddle()
    {
        float nuevaY = this.gameObject.transform.position.y + (PaddleDirection() * moveSpeed * Time.deltaTime);

        if (nuevaY > topheight)
        {
            nuevaY = topheight;
        }

        if (nuevaY < botheight)
        {
            nuevaY = botheight;
        }
        return nuevaY;
    }


    float PaddleDirection()
    {
        float direccion = 0f;
        if (useArrowKeys == true)
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                direccion = 1f;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                direccion = -1f;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                direccion = 1f;
            }

            if (Input.GetKey(KeyCode.S))
            {
                direccion = -1f;
            }
        }
            return direccion;


    }
    void MovePaddleIA()
    {
        int direccion = 0;
        float diferencia = ball.transform.position.y - transform.position.y;

        if (diferencia > IAFollowTolerance)
        {
            direccion = 1;
        }

        else if (diferencia < IAFollowTolerance)
        { 
            direccion = -1;
        }

        float nuevaY = transform.position.y * (direccion * moveSpeed / 2 * Time.deltaTime);
    }

}
