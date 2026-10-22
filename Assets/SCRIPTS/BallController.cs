using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float velocidad = 10f;
    Rigidbody2D _rb;
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody2D>();

        Launchball();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        _rb.velocity = _rb.velocity.normalized * velocidad;

    }
    void Launchball()
    {
        bool isRight = false;
        if (Random.value > 0.5f)
        {
            isRight = true;
        }

        float xVelocity = -1;
        if (isRight == true)
        {
            xVelocity = 1;
        }

        float yVelocity = Random.Range(-1f, 1f);
        _rb.velocity = new Vector2(xVelocity * xVelocity, yVelocity * yVelocity);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ball Hit");
        manager.Playernumber1++;
        Debug.Log(manager.Playernumber1);

        
    }

   
}



