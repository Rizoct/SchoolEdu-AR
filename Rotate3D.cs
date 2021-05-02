using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate3D : MonoBehaviour
{
    public bool putar = false;
    public Vector3 KecepatanPutaran;

    // Update is called once per frame
    void Update()
    {
        if(putar)
        {
            transform.Rotate(
                KecepatanPutaran.x * Time.deltaTime * 10,
                KecepatanPutaran.y * Time.deltaTime * 10,
                KecepatanPutaran.z * Time.deltaTime * 10
            );
        }
        
    }
}
