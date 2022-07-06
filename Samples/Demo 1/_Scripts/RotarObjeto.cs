using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarObjeto : MonoBehaviour
{

    [SerializeField] private float _velocidad;
    [SerializeField] private Vector3 _direccionDeRotacion;
    [SerializeField] private float _suavidad;

    private Quaternion _rotacionActual;

    private void Awake()
    {
        _rotacionActual = transform.rotation;
    }

    private void Update()
    {
        Vector3 rotacion = _direccionDeRotacion * _velocidad + _rotacionActual.eulerAngles;
        Quaternion target = Quaternion.Euler(rotacion.x, rotacion.y, rotacion.z);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * _suavidad);
        _rotacionActual = transform.rotation;
    }
}
