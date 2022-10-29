using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static float timecontrol = 0;
    public Text textTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        timecontrol += Time.deltaTime;
        textTime.text = "Time:" + timecontrol.ToString("f0");
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("SampleScene");
            timecontrol = 0;
            ScoreControl.score = 0;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}
