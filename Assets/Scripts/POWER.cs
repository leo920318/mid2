using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POWER : MonoBehaviour

{
    public float speed = 8;
    public GameObject explosion;
    public AudioSource m_audioSource;
    //public GameObject heart1;
    //public GameObject heart2;
    //public GameObject heart3;
    //int HeartNum = 3;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(-speed * Time.deltaTime, -speed * Time.deltaTime, 0);

        transform.Translate(0, speed * Time.deltaTime, 0);


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "walldown")
        {
            Destroy(this.gameObject);
        }
        if (collision.name == "Ship")
        {
            Destroy(this.gameObject);
        }
    }
}