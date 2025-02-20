using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    [Header("Assign your two camera GameObjects (not components)")]
    public GameObject interiorCamera;
    public GameObject exteriorCamera;

    // Flag to track which camera is active (start with exterior active)
    private bool isExteriorActive = true;

    void Start()
    {
        // Check for assignments
        if (interiorCamera == null || exteriorCamera == null)
        {
            Debug.LogError("CameraToggle: Please assign both camera GameObjects in the Inspector!");
            return;
        }
        
        // Start with the exterior camera active
        ActivateExterior();
    }

    // Activate the interior camera and deactivate the exterior camera
    public void ActivateInterior()
    {
        if (interiorCamera == null || exteriorCamera == null)
            return;

        interiorCamera.SetActive(true);
        exteriorCamera.SetActive(false);
        isExteriorActive = false;
        Debug.Log("Activated Interior Camera");
    }

    // Activate the exterior camera and deactivate the interior camera
    public void ActivateExterior()
    {
        if (interiorCamera == null || exteriorCamera == null)
            return;

        interiorCamera.SetActive(false);
        exteriorCamera.SetActive(true);
        isExteriorActive = true;
        Debug.Log("Activated Exterior Camera");
    }

    // Toggle between interior and exterior cameras
    public void ToggleCameras()
    {
        if (isExteriorActive)
        {
            ActivateInterior();
        }
        else
        {
            ActivateExterior();
        }
    }
}
