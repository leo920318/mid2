using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnBtn()
    {
        SceneManager.LoadScene("level1");

    }
    public void OnBtn2()
    {
        Application.Quit();

    }
    
}

