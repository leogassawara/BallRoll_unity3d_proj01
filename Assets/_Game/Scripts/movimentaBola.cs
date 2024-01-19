using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class movimentaBola : MonoBehaviour
{
    private Rigidbody rb;

    public float velocidade;

    public GameObject particulaItem;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3 (UnityEngine.Input.GetAxis("Horizontal"), 0, UnityEngine.Input.GetAxis("Vertical"));
        rb.AddForce(move * velocidade);
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            Instantiate(particulaItem, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
