using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{

    public AudioClip coinclip;
    public AudioClip hazardClip;


    public GameManager gm;
    public float speed = 5;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");

        
        transform.Translate(xMove * speed * Time.deltaTime , 0, 0);



    }

 ///private void OnCollisionEnter(Collision collision)
 ///{

 ///    Debug.Log("Collided");

 ///}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            gm.PlaySound(coinclip);
            gm.IncrementScore(1);
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "Hazard")
        {
            gm.PlaySound(hazardClip);
            Destroy(gameObject);

        }

    }

}


