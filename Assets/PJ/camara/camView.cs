using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camView : MonoBehaviour
{

    public GameObject target;
     public Vector3 v3;
     public float speed;
     public float maxLook, minLook;
     public Quaternion camRotation;
     void Start()
     {
         camRotation = transform.localRotation;
     }
     private float controlSpeed=0f;
     public float aceleracionSpeed = 1f;
     public float maxIner, descuentoIner;
     private float iner = 0;
     private float dirX;
     public void cam()
     {
         if (target)
         {
             transform.position = target.transform.position;// + v3;
         }
         camRotation.y += Input.GetAxis("H2") * controlSpeed + iner;
         camRotation.x += Input.GetAxis("V2") * speed * -1;

         controlSpeed += aceleracionSpeed * Time.deltaTime;
         if (controlSpeed > speed)controlSpeed = speed;

         camRotation.x = Mathf.Clamp(camRotation.x, minLook, maxLook);

         transform.localRotation = Quaternion.Euler(camRotation.x, camRotation.y, camRotation.z);

     }
     // Update is called once per frame
     void Update()
     {
         cam();
     }
  

}
