using UnityEngine;

public class GravityChanger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float SpaceGrav;
    public float StableGrav;
    public float Spacejumpheight;
    public float Stablejumpheight;
    public PlayerMovement playerMovement;


    private void OnTriggerEnter(Collider other)
    {
        playerMovement.gravity = StableGrav;
        playerMovement.jumpHeight = Stablejumpheight;
       
    }

    private void OnTriggerExit(Collider other)
    {
        playerMovement.gravity = SpaceGrav;
        playerMovement.jumpHeight = Spacejumpheight;
     
    }
}
