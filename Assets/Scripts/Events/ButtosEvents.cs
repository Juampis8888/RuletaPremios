using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtosEvents : MonoBehaviour, IPointerEnterHandler // interfaz requerida cuando se usa el m�todo OnPointerEnter.
{
    // Haga esto cuando el cursor entre en el �rea rect de este objeto de interfaz de usuario seleccionable.
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("El cursor ingres� al elemento de la interfaz de usuario seleccionable.");
    }
}
