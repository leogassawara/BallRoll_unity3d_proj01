using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroiObjeto : MonoBehaviour
{
    
    void Start()
    {
        Invoke("ApagaObjeto", 1.5f);
    }

    void ApagaObjeto()
    {
        Destroy(this.gameObject);
    }
}
