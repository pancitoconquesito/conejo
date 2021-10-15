using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class START : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UI;
    private void Awake()
    {
        UI.SetActive(true);
    }
    private bool first_update = false;
    void Start()
    {

    }
    private void primerFrame()
    {
        GameObject.Find("UI/TS").SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Astronomia");
        }
        if (!first_update)
        {
            first_update = true;
            primerFrame();
        }
    }
    
}
