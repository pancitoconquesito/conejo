using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estados_S : MonoBehaviour
{
    private string botonAbajo = "Fire2";

    [SerializeField] private int _ESTADO=0;
    private GameObject obj_camPrincipalPJ;
    Dictionary<string, int> d_estado = new Dictionary<string, int>
    {
        { "JN",0 },
        { "ILS", 1},
        { "ILS_ENTER", 2},//3 salir de ils
        {"JN_SALIR",3},
    };

    void Start()
    {
        obj_camPrincipalPJ = GameObject.FindGameObjectWithTag("MainCamera");
        ampolleta= GameObject.FindGameObjectWithTag("pj/ampolleta");
        ampolleta.SetActive(false);
    }
    public int getEstado_int()
    {
        return _ESTADO;
    }
    public void setEstado(string valor)
    {
        
        if (valor == "JN_SALIR")
        {
            GameObject.FindGameObjectWithTag("PJ").GetComponent<Animator>().SetTrigger("volver_a_JN");
            Invoke("volver_a_JN", 1.5f);
        }
        else _ESTADO = d_estado[valor];
    }
    private void volver_a_JN()
    {
        
        _ESTADO = 0;
    }

    private GameObject ampolleta;
    private void OnTriggerStay(Collider other)
    {
        if (_ESTADO == d_estado["JN"])
        {
            if ( other.CompareTag("ils") )
            {
                //other.gameObject.transform.GetComponent<dialogoSimple>().prenderAmpolleta();
                //ampolleta.SetActive(true);
                if ( Input.GetButton(botonAbajo))
                {
                    ampolleta.SetActive(false);
                    GameObject.FindGameObjectWithTag("cc").GetComponent<move>().set_new_position_pj(other.GetComponentInChildren<dialogoSimple>().get_new_position());
                    _ESTADO = d_estado["ILS"];
                    //dialogo simple de other obj y asignar posicion de look pivote de pj
                    other.gameObject.transform.GetComponent<dialogoSimple>().setPivoteLook();
                }
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (_ESTADO == d_estado["JN"])
        {
            if (other.CompareTag("ils"))
            {
                ampolleta.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ils"))
        {
            ampolleta.SetActive(false);
        }
    }
}
