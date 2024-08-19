using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturn : MonoBehaviour
{

    public float selfRotateSpeed = 1.0f;
    public float saturnOrbitSpeed = 9.69f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject soleil = GameObject.Find("Soleil");
        GameObject saturn = GameObject.Find("Saturn");

        if (soleil == null || saturn == null)
        {
            Debug.Log("L'un des deux objets n'existe pas !!");

        }

    }

    // Update is called once per frame
    void Update()
    {

        GameObject soleil = GameObject.Find("Soleil");
        GameObject saturn = GameObject.Find("Saturn");

        saturn.transform.Rotate(0, selfRotateSpeed * Time.deltaTime, 0);
        transform.RotateAround(soleil.transform.position, - soleil.transform.up, saturnOrbitSpeed * Time.deltaTime);
    }
}
