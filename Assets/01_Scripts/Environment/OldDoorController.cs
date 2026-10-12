using UnityEngine;

public class OldDoorController : MonoBehaviour
{
    [SerializeField] private bool isOpen;

    public void OpenDoor()
    {
       if (isOpen)
       {
           Debug.Log("La puerta ya está abierta.");
           return;
       }

       isOpen = true;
       Debug.Log("Puerta abierta (controlador antiguo).");
    }
}