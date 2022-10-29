using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontrol : MonoBehaviour
{
    public float speed=10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "walltop")
        {
            Destroy(this.gameObject);

        }
        if (collision.name == "Monsterpref(Clone)")
        {
            Destroy(this.gameObject);

        }
    }
}

