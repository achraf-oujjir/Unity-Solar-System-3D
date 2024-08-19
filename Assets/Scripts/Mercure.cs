using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercure : MonoBehaviour
{
    public float selfRotateSpeed = 1.0f;
    public float mercuryOrbitSpeed = 47.87f;
    // Start is called before the first frame update
    void Start()
    {   GameObject soleil = GameObject.Find("Soleil");
        GameObject mercure = GameObject.Find("Mercure");
        if (soleil == null || mercure == null)
        {Debug.Log("L'un des deux objets n'existe pas !!");}
    }

    // Update is called once per frame
    void Update()
    {   GameObject soleil = GameObject.Find("Soleil");
        GameObject mercure = GameObject.Find("Mercure");
        mercure.transform.Rotate(0, selfRotateSpeed * Time.deltaTime, 0);
        transform.RotateAround(soleil.transform.position,
            - soleil.transform.up, mercuryOrbitSpeed * Time.deltaTime);
    }
}
