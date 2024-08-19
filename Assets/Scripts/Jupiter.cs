using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jupiter : MonoBehaviour
{
    // Start is called before the first frame update

    public float jupiterOrbitSpeed = 13.07f;
    public float selfRotateSpeed = 1.0f;


    void Start()
    {
        GameObject soleil = GameObject.Find("Soleil");
        GameObject jupiter = GameObject.Find("Jupiter");
       if (soleil == null || jupiter == null)
        {
            Debug.Log("L'un des deux objets n'existe pas !!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject soleil = GameObject.Find("Soleil");
        GameObject jupiter = GameObject.Find("Jupiter");
        jupiter.transform.Rotate(0, selfRotateSpeed * Time.deltaTime, 0);
        transform.RotateAround(soleil.transform.position, - soleil.transform.up, jupiterOrbitSpeed * Time.deltaTime);
    }
}
