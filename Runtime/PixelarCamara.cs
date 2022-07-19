using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class PixelarCamara : MonoBehaviour
{
    [SerializeField] private uint _anchoDeLaPantalla;

    private RenderTexture _renderTextura;

    private void Start()
    {
        Camera camara = GetComponent<Camera>();

        float relacionDeAspectos = camara.aspect;
        float altoDePantalla = AltoDeLaPantalla(_anchoDeLaPantalla, relacionDeAspectos);

        _renderTextura = new RenderTexture(_anchoDeLaPantalla, altoDePantalla);



        camara.targetTexture = _renderTextura;
    }

    private float AltoDeLaPantalla(float anchoDeLaPantalla, float relacionDeAspectos)
    {
        return Mathf.CeilToInt(anchoDeLaPantalla / relacionDeAspectos);
    }
}
