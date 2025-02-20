using UnityEngine;

public class InteriorFollowAR : MonoBehaviour
{
    public Transform interior; // Assign the interior parent object here

    private void Start()
    {
        if (interior == null)
        {
            Debug.LogError("Interior reference is missing! Assign it in the Inspector.");
        }
    }

    private void Update()
    {
        if (interior != null)
        {
            // Keep the interior at the same position as the XR Origin
            interior.position = transform.position;
            interior.rotation = transform.rotation;
        }
    }
}
