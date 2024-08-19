using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terre : MonoBehaviour
{

    public float selfRotateSpeed = 1.0f;
    public float earthOrbitSpeed = 29.78f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject soleil = GameObject.Find("Soleil");
        GameObject terre = GameObject.Find("Terre");

        if (soleil == null || terre == null)
        {
            Debug.Log("L'un des deux objets n'existe pas !!");

        }

    }

    // Update is called once per frame
    void Update()
    {

        GameObject soleil = GameObject.Find("Soleil");
        GameObject terre = GameObject.Find("Terre");

        terre.transform.Rotate(0, selfRotateSpeed * Time.deltaTime, 0);
        transform.RotateAround(soleil.transform.position, - soleil.transform.up, earthOrbitSpeed * Time.deltaTime);
    }
}
