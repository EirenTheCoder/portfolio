using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistScript : MonoBehaviour
{
    enum Fighters
    {

        Player,
        Npc

    }

    [SerializeField] Fighters fighters;
    Vector3 mousePos = Vector3.zero;
    Vector3 lookPos = Vector3.zero;
    float angle = 0;
    [SerializeField] private float speed = 1f;
    private void Start()
    {

    }

    private void Update()
    {
        switch (fighters)
        {
            case Fighters.Player:
         
        // Obtener la posición del mouse en la pantalla
        Vector3 posicionMouse = Input.mousePosition;

        // Convertir la posición del mouse de la pantalla al mundo 3D
        Vector3 posicionMouseEnMundo = Camera.main.ScreenToWorldPoint(posicionMouse);

        // Ignorar la posición del mouse en el eje X
        posicionMouseEnMundo.x = transform.position.x;

        // Calcular la dirección de rotación desde el objeto hacia la posición del mouse en el mundo
        Vector3 direccionRotacion = posicionMouseEnMundo - transform.position;

direccionRotacion.z = Mathf.Clamp(direccionRotacion.z,50,130);
        // Calcular la rotación en función de la dirección de rotación
        Quaternion rotacionDeseada = Quaternion.LookRotation(direccionRotacion, Vector3.forward);


        // Interpolar suavemente hacia la rotación deseada
        transform.rotation = Quaternion.Lerp(transform.rotation, rotacionDeseada, speed * Time.deltaTime);
   break;
            case Fighters.Npc:



                break;


        }
    }
}