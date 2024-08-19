using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mars : MonoBehaviour
{

    public float selfRotateSpeed = 1.0f;
    public float marsOrbitSpeed = 24.08f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject soleil = GameObject.Find("Soleil");
        GameObject mars = GameObject.Find("Mars");

        if (soleil == null || mars == null)
        {
            Debug.Log("L'un des deux objets n'existe pas !!");

        }

    }

    // Update is called once per frame
    void Update()
    {

        GameObject soleil = GameObject.Find("Soleil");
        GameObject mars = GameObject.Find("Mars");


        mars.transform.Rotate(0, selfRotateSpeed * Time.deltaTime, 0);
        transform.RotateAround(soleil.transform.position, - soleil.transform.up, marsOrbitSpeed * Time.deltaTime);
    }
}
