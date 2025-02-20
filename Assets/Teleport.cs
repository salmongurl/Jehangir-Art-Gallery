using UnityEngine;

public class Teleport : MonoBehaviour 
{
    public Transform interior;
    public Transform exterior;

    public GameObject camera;

    bool isInInterior = false;

    public void TeleportTo() {
        isInInterior = !isInInterior;
        if (isInInterior) {
            camera.transform.position = interior.position;
        } else {
            camera.transform.position = exterior.position;
        }
    }
}