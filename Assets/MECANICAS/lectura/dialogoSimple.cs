using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialogoSimple : MonoBehaviour
{
    //private Estados_S estadoPJ;
    private GameObject pivotteLook;
    private Vector3 mirada_;
    private GameObject cam_Lectura;
    private GameObject pjobjRef;
    private move ccScript;
    private GameObject pivCamLook_PJ;
    private TextMeshProUGUI texto_ui;
    private GameObject UI_TS;
    private Image UI_continuar;

    private bool checkComenzar = false;
    private bool check = false;
    private bool checkBoton = false;
    private int flujo = 0, indice = 0;

    private Estados_S estado_pj;

    //[Header("--- Pivote donde mirará ---")]
    //public GameObject mirada_obj;
    //public GameObject obj_new_posicion_pj;
    private Vector3 new_posicion_pj;
    [Header("--- Texto Para Mostar en UI ---")]
    [TextArea]public string[] _texto;
    
    public Vector3 get_new_position()
    {
        return new_posicion_pj;
    }
    //private GameObject obj_camPrincipalPJ;
    private void Awake()
    {
        
    }
    private Animator animFlecha;
    private setSprite setSpriteFlecha;
    void Start()
    {
        //new_posicion_pj = obj_new_posicion_pj.transform.position;

        UI_TS = GameObject.Find("UI/TS");
        UI_continuar = GameObject.Find("UI/TS/Image/continuar").GetComponent<Image>();
        animFlecha = GameObject.Find("UI/TS/Image/continuar").GetComponent<Animator>();
        setSpriteFlecha = GameObject.Find("UI/TS/Image/continuar").GetComponent<setSprite>();

        texto_ui = GameObject.FindGameObjectWithTag("TS-text").GetComponent<TextMeshProUGUI>();

        estado_pj = GameObject.FindGameObjectWithTag("PJ").GetComponent<Estados_S>();

        

        //estadoPJ = GameObject.FindGameObjectWithTag("PJ").GetComponent<Estados_S>();
        pivotteLook = GameObject.FindGameObjectWithTag("pivote_look");
        cam_Lectura = GameObject.FindGameObjectWithTag("cam_lectura");
        pivCamLook_PJ = GameObject.FindGameObjectWithTag("pivCamLook");

        GameObject padre = transform.parent.gameObject;
        int cantidad_hijos = padre.transform.childCount;
        for(int i = 0; i < cantidad_hijos; i++)
        {
            GameObject objActual = padre.transform.GetChild(i).gameObject;
            if (objActual.CompareTag("ils_new_pos"))
            {
                new_posicion_pj = objActual.transform.position;
            }else if (objActual.CompareTag("ils_mirada"))
            {
                mirada_ = objActual.transform.position;
            }


        }
        //mirada_ = mirada_obj.transform.position;
        pjobjRef = GameObject.FindGameObjectWithTag("cc");
        ccScript = pjobjRef.GetComponent<move>();

        //
        //if(UI_TS)
        //    UI_TS.SetActive(false);
        //
        StopAllCoroutines();
        checkComenzar = false;
        check = false;
        checkBoton = false;
        flujo = 0;
        indice = 0;
    }
    
    void Update()
    {
        if (check)
        {
            //gestion de camara y pivote donde apunta
            //if(GameObject.FindGameObjectWithTag("MainCamera")!=null)
                //cam_Lectura.transform.position = Vector3.MoveTowards(GameObject.FindGameObjectWithTag("MainCamera").transform.position, pivCamLook_PJ.transform.position, Time.deltaTime * 8f);
           // else
               cam_Lectura.transform.position = pivCamLook_PJ.transform.position;

            //arrancar conversacion
            if (!checkComenzar)
            {checkComenzar = true;
                StartCoroutine(comenzarParrafo());
            } 

            //gestion de textos
            switch (flujo)
            {
                case 1://espero boton y veo si continuo o salgo
                    {
                        Debug.Log("esperando boton");
                    
                        if (Input.GetButton(btn_Continuar) && !checkBoton)
                        {checkBoton = true;
                            indice++;
                            if (indice == _texto.Length) salir();// salgo de la conversacion
                            else StartCoroutine(comenzarParrafo());// continuo con un nuevo parrafo
                        }
                        break;
                    }
            }
        }
    
    }
    private void salir()
    {flujo = 2;
        //anim salir

        UI_TS.SetActive(false);
        UI_continuar.enabled = false;
        StopAllCoroutines();
        checkComenzar = false;
        check = false;
        checkBoton = false;
        flujo = 0;
        indice = 0;
        estado_pj.setEstado("JN_SALIR");
    }
    public void setPivoteLook()
    {
        //cam_Lectura.transform.position = GameObject.FindGameObjectWithTag("MainCamera").transform.position;
        Vector3 vector = (mirada_ - pjobjRef.transform.position).normalized;
        ccScript.setDir_lecturaSimple(vector);
        check = true;
        Invoke("moverPivote",1f);
    }
    private void moverPivote()
    {
        pivotteLook.transform.position = mirada_;
    }
    private string btn_Continuar="Fire2",bnt_salir="Fire3";
    IEnumerator comenzarParrafo()
    {

        if (flujo == 0)
        {
            yield return new WaitForSeconds(2.5f);
            //UI_TS = GameObject.Find("UI/TS");
            UI_TS.SetActive(true);
        }  
        else
        {
            yield return new WaitForSeconds(0.1f);
            UI_continuar.enabled = false;
            yield return new WaitForSeconds(0.05f);
        }
        

        checkBoton = false;
        flujo = 0;

        string cadenaActual = "";
        texto_ui.text = "";
        //corrutinas, OJO, tanto para array como para string, su largo es con Length
        bool salir = false;
        do
        {
            switch (flujo)
            {
                case 0:// escribo en pantalla
                    {
                        int i;
                        for (i = 0; i <_texto[indice].Length; i++)
                        {
                            cadenaActual += _texto[indice].Substring(i, 1);
                            texto_ui.text = cadenaActual;
                            yield return new WaitForSeconds(0.01f);
                        }
                        if (i == _texto[indice].Length)
                        {
                            yield return new WaitForSeconds(0.1f);
                            flujo = 1;
                        }
                        break;
                    }
                case 1://salir del flujo
                    {
                        //muestro boton de continuar
                        UI_continuar.enabled = true;
                        if (indice+1==_texto.Length) setSpriteFlecha.setIdSprite(1);
                        else setSpriteFlecha.setIdSprite(0);

                        animFlecha.SetTrigger("start");
                        salir = true;
                        break;
                    }
            }  
        } while (!salir);  
    }
    
}
