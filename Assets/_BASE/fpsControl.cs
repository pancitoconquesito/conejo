using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class fpsControl: MonoBehaviour
{
    [Header("--- UI DEMO ---")]
    public float timer, refresh, avgFramerate;
    public string display = "{0} FPS";
    private TextMeshProUGUI m_Text;
    public int fpsLimite;

   
    void Start()
    {
        m_Text = GameObject.Find("UI/debug/text").transform.GetComponent<TextMeshProUGUI>();
    }
   
    void Update()
    {
        float timelapse = Time.smoothDeltaTime;
        timer = timer <= 0? refresh : timer -= timelapse;
        if (timer <= 0) avgFramerate = (int)(1f / timelapse);
        m_Text.text = string.Format(display,avgFramerate.ToString());
        
        if(Application.targetFrameRate > fpsLimite)
            Application.targetFrameRate = fpsLimite;  

    }
}
