using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    [Header("referencias")]
    public CharacterController cc;
    public GameObject pjref;
    public Transform cam;

    [Header("Configuracion movimiento")]
    public float velocidad = 5f;
    public float turnsmoothTime = 0.1f;
    public float turnSmoothVelocity;
    [Header("Serialized")]
    [SerializeField]private bool corriendo;
    [SerializeField] private float velocidadExtraCorrer = 1.4f;
    private Vector3 moveDirection;
    private Animator animPjref;

    [Header("Salto/gravedad")]
    [SerializeField]private bool suelo;
    public float jumpPotencia = 5f;
    private float GRAVEDAD = -9.8f;
    public float gravedadActual = -9.8f;
    public float factorGravedad = 0.25f;

    //referencias
    private Estados_S misEstados;
    private void Start()
    {
        animPjref = pjref.GetComponent <Animator>();
        gravedadActual *=factorGravedad;
        //
        misEstados = GameObject.FindGameObjectWithTag("PJ").GetComponent<Estados_S>();
    }
    private void Update()
    {

        switch (misEstados.getEstado_int())
        {
            //3:salir de ils
            case 0://JN
                {
                    float horizontal = Input.GetAxis("Horizontal"); float vertical = Input.GetAxis("Vertical");
                    Vector3 direccion = new Vector3(horizontal, 0, vertical).normalized;
                    float valorMagnitudMov = direccion.magnitude;
                    float aaa = new Vector3(horizontal, 0, vertical).magnitude;
                    aaa = Mathf.Clamp(aaa, 0f, 1f);
                    //Debug.Log("horizontal : "+ horizontal+"___vertical : "+vertical+" ahhh" + aaa);
                    valorMagnitudMov = aaa;
                    //correr
                    if(valorMagnitudMov >= 0.1f)
                        animPjref.SetFloat("velocidad", valorMagnitudMov);
                    else animPjref.SetFloat("velocidad", 0f);
                    corriendo = valorMagnitudMov > 0.7f && Input.GetButton("correr");
                    animPjref.SetBool("run", corriendo);

                    //mov
                    if (valorMagnitudMov >= 0.1f)
                    {

                        float targetAngulo = Mathf.Atan2(direccion.x, direccion.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                        float angulo = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngulo, ref turnSmoothVelocity, turnsmoothTime);
                        transform.rotation = Quaternion.Euler(0f, angulo, 0f);
                        moveDirection = Quaternion.Euler(0f, targetAngulo, 0f) * Vector3.forward;

                        if (corriendo)
                        {
                            moveDirection.x *= velocidadExtraCorrer;
                            moveDirection.z *= velocidadExtraCorrer;
                        }

                        moveDirection.x *= velocidad* valorMagnitudMov;
                        moveDirection.z *= velocidad* valorMagnitudMov;
                        gravedad();
                        cc.Move(moveDirection * Time.fixedDeltaTime);
                    }
                    else
                    {
                        cc.Move(new Vector3(0, gravedad(), 0) * Time.deltaTime);
                    }
                    break;
                }
            case 1://ILS
                {
                    animPjref.SetTrigger("ils_enter");
                    //transform.rotation = Quaternion.Euler(0,0,0);
                    transform.position = Vector3.MoveTowards(transform.position, new_position_pj, Time.deltaTime*3f);
                    
                    break;
                }
            case 2://ILS_ENTER
                {
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(new_position_pj.x, transform.position.y, new_position_pj.z), Time.deltaTime * 2f);
                    Quaternion rotacion = Quaternion.LookRotation(dir_lecturaSimple);
                    rotacion.x = transform.rotation.x;
                    rotacion.z = transform.rotation.z;
                    transform.rotation=Quaternion.Slerp(transform.rotation, rotacion, 6f * Time.deltaTime);
                    break;
                }
        }

    }
    private Vector3 new_position_pj;
    public void set_new_position_pj(Vector3 new_pos)
    {
        new_position_pj = new_pos;
    }
    private Vector3 dir_lecturaSimple;
    public void setDir_lecturaSimple(Vector3 dir)
    {
        dir_lecturaSimple = dir;
    }
    private float gravedad()
    {
        suelo = cc.isGrounded;
        if (suelo && moveDirection.y < 0)
        {
            //moveDirection.y = 0f;
            moveDirection.y = gravedadActual ;
        }
        else
        {
            moveDirection.y += gravedadActual ;
        }
        //salto
        if (Input.GetButtonDown("Jump") && suelo)
        {
            //moveDirection.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
        return moveDirection.y;
    }
}

