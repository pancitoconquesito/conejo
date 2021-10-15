using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pjref;
    private Animator animPJ;
    private int estadoValor=0;
    void Start()
    {
        animPJ = pjref.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z)) changeEstado(1);
        if (Input.GetKey(KeyCode.X)) changeEstado(2);
        if (Input.GetKey(KeyCode.C)) changeEstado(3);

    }
    private void changeEstado(int valor)
    {
        animPJ.SetInteger("estado", valor);
    }
}
