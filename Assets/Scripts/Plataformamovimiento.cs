using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformamovimiento : MonoBehaviour
{
    public float xSpeed;
    public bool toRight;

    public GameObject Prefab1;

    public GameObject Prefab2;

    public GameObject cuboizq;
    public GameObject cuboder;
    // Start is called before the first frame update
    void Start()
    {
        toRight = true;   
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (transform.position.x > 4)
        {
            toRight = false;
            GameObject clon;
            clon = Instantiate(Prefab1);
            clon.transform.position = cuboder.transform.position + new Vector3(0, 1, 0);
        }
        if (transform.position.x < -4)
        {
            toRight = true;
            GameObject clon;
            clon = Instantiate(Prefab2);
            clon.transform.position = cuboizq.transform.position + new Vector3(0, 1, 0);
        }

    }
}
