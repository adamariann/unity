using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObjek : MonoBehaviour
{
    public Vector3 kekanan;
public float speed;	
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (kekanan * speed * Time.deltaTime);
    }
}
