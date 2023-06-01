using UnityEngine;
using UnityEngine.UI;

public class METRO : MonoBehaviour
{
    public Transform carTransform;
    public Text distanceText;
    private Vector3 lastPosition;
    private float totalDistance;

    private void Start()
    {
        lastPosition = carTransform.position;
    }

    private void Update()
    {
        Vector3 currentPosition = carTransform.position;
        float distance = Vector3.Distance(lastPosition, currentPosition);
        totalDistance += distance;
        lastPosition = currentPosition;

        distanceText.text = "Distancia recorrida: " + totalDistance.ToString("F2") + " metros";
    }
}
