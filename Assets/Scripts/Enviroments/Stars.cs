using UnityEngine;

public class SkyboxFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float rotationSpeed = 0.5f;

    private float currentXRotation = 0f;

    void LateUpdate()
    {
        if (playerTransform != null)
        {
            transform.position = playerTransform.position;
        }


        currentXRotation += rotationSpeed * Time.deltaTime;

       
        transform.rotation = Quaternion.Euler(currentXRotation, 0f, 0f);
    }
}