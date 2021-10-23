using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class setSprite : MonoBehaviour
{
    public Sprite[] imgBoton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setIdSprite(int idSprite)
    {
        gameObject.GetComponent<Image>().sprite = imgBoton[idSprite];
    }
}
