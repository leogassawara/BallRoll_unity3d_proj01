using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.UI;
using TMPro;

public class movimentaBola : MonoBehaviour
{
    private Rigidbody rb;

    public float velocidade;

    public GameObject particulaItem;

    public TMP_Text textoPontos;
    public TMP_Text textoFinal;

    private int pontos;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        textoFinal.text = "";

        textoPontos.text = textoPontos.text + pontos.ToString();
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3 (UnityEngine.Input.GetAxis("Horizontal"), 0, UnityEngine.Input.GetAxis("Vertical"));
        rb.AddForce(move * velocidade);
     
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            Instantiate(particulaItem, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            MarcaPonto();
  
        }
    }

    void MarcaPonto()
    {
        pontos++;
        textoPontos.text = "Score: " + pontos.ToString();
        if (pontos == 4)
        {
            textoFinal.text = "You Win!!!";
        }
    }
}
