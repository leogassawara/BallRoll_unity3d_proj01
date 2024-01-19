using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class movimentaBola : MonoBehaviour
{
    private Rigidbody rb;

    public float velocidade;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3 (UnityEngine.Input.GetAxis("Horizontal"), 0, UnityEngine.Input.GetAxis("Vertical"));
        rb.AddForce(move * velocidade);
     
    }
}
