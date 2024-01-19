using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public GameObject objetoBolinha;
    private Vector3 posicaoInicial;
    
    void Start()
    {
        posicaoInicial = transform.position - objetoBolinha.transform.position;
    }

    void LateUpdate()
    {
        transform.position = objetoBolinha.transform.position + posicaoInicial;
    }
}
