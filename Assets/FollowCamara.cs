using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; // Referencia al objeto carro

    void Update()
    {
        // Verifica si se ha asignado un objetivo
        if (target == null)
        {
            Debug.LogWarning("No se ha asignado un objetivo a la cámara.");
            return;
        }

        // Calcula la posición objetivo de la cámara
        Vector3 targetPosition = target.position;

        // Agrega un desplazamiento adicional para un efecto de seguimiento suave
        targetPosition.z -= 10; // Ajusta este valor según tu escala de la escena

        // Actualiza la posición de la cámara
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5);
    }
}