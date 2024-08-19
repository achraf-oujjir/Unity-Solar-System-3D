using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour
{

    public float selfRotateSpeed = 1.0f;
    public float venusOrbitSpeed = 35.02f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject soleil = GameObject.Find("Soleil");
        GameObject venus = GameObject.Find("Venus");

        if (soleil == null || venus == null)
        {
            Debug.Log("L'un des deux objets n'existe pas !!");

        }

    }

    // Update is called once per frame
    void Update()
    {

        GameObject soleil = GameObject.Find("Soleil");
        GameObject venus = GameObject.Find("Venus");

        venus.transform.Rotate(0, selfRotateSpeed * Time.deltaTime, 0);
        transform.RotateAround(soleil.transform.position, - soleil.transform.up, venusOrbitSpeed * Time.deltaTime);
    }
}
