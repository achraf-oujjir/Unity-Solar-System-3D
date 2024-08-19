using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neptune : MonoBehaviour
{

    public float selfRotateSpeed = 1.0f;
    public float neptuneOrbitSpeed = 5.43f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject soleil = GameObject.Find("Soleil");
        GameObject neptune = GameObject.Find("Neptune");

        if (soleil == null || neptune == null)
        {
            Debug.Log("L'un des deux objets n'existe pas !!");

        }

    }

    // Update is called once per frame
    void Update()
    {

        GameObject soleil = GameObject.Find("Soleil");
        GameObject neptune = GameObject.Find("Neptune");

        neptune.transform.Rotate(0, selfRotateSpeed * Time.deltaTime, 0);
        transform.RotateAround(soleil.transform.position, - soleil.transform.up, neptuneOrbitSpeed * Time.deltaTime);
    }
}
