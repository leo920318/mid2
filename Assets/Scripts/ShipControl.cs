using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipControl : MonoBehaviour
{
    public float speed = 0.005f;
    public GameObject Bullet;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    int HeartNum = 3;
    public AudioSource m_audiosource;
    public AudioClip m_hittedSound;
    public GameObject textFail;
    public GameObject textSuccess;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (GameControl.timecontrol > 60)
        {
            if (ScoreControl.score > 20)
            {
                textSuccess.SetActive(true);
                this.gameObject.SetActive(false);
                SceneManager.LoadScene("end");
            }
            else
            {
                textFail.SetActive(true);
                this.gameObject.SetActive(false);
                SceneManager.LoadScene("end");
            } 
        }
        if (ScoreControl.score > 20)
        {
            textSuccess.SetActive(true);
            this.gameObject.SetActive(false);
            SceneManager.LoadScene("end");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed*Time.deltaTime, 0, 0);

    }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);

        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
           
            Instantiate(Bullet, transform.position+new Vector3(0.1f, 0,0), transform.rotation);
            m_audiosource.Play();
            
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "E_S(Clone)")
        {
            m_audiosource.PlayOneShot(m_hittedSound);
            HeartNum--;
            if (HeartNum == 2)
                heart1.SetActive(false);
            else if (HeartNum == 1)
                heart2.SetActive(false);
            else if (HeartNum == 0)
            {
                heart3.SetActive(false);
                textFail.SetActive(true);
                this.gameObject.SetActive(false);
                SceneManager.LoadScene("end");
            }
        }
    }
}