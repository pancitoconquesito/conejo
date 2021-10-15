using UnityEngine;

public class rotacion : MonoBehaviour
{
    public Vector3 velocidadRotacion;

    void Update()
    {
        transform.Rotate(velocidadRotacion*Time.deltaTime);
    }
}
