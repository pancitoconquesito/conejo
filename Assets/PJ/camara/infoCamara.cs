using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoCamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private Vector3 camForward,camright;
    void Update()
    {

    }
    public Vector3 getForward()
    {
        Vector3 vectorR= transform.forward.normalized;
        vectorR.y = 0;
        return vectorR;
    }
    public Vector3 getRight()
    {
        Vector3 vectorR = transform.right.normalized;
        vectorR.y = 0;
        return vectorR;
    }
}
