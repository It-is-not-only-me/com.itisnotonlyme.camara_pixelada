using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class PixelarCamara : MonoBehaviour
{
    [SerializeField] private RenderTexture _renderTextura;
    [SerializeField] private uint _anchoDeLaPantalla;

    private void Start()
    {
        Camera camara = GetComponent<Camera>();

        float relacionDeAspectos = camara.aspect;
        ActualizarDimension(relacionDeAspectos);

        camara.targetTexture = _renderTextura;
    }

    private void ActualizarDimension(float relacionDeAspectos)
    {
        int altoDeLaPantalla = Mathf.CeilToInt(_anchoDeLaPantalla / relacionDeAspectos);

        _renderTextura.width = (int)_anchoDeLaPantalla;
        _renderTextura.height = altoDeLaPantalla;
    }
}
