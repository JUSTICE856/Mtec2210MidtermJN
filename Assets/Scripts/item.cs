using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class item : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }

    }
}
