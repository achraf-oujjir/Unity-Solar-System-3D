using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{

    public float sensitivity = 5.0f;
    public float maxYAngle = 80.0f;
    private Vector2 currentRotation;

    void Start()
    {
        // Bloque et cache le curseur dans la fen�tre de jeu
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Calcule la rotation de la cam�ra en fonction du mouvement de la souris
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);

        // Applique la rotation � la cam�ra
        transform.localRotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0.0f);

        // Si la touche �chap est enfonc�e, d�bloque le curseur
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}