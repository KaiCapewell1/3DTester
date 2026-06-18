using UnityEngine;

public class OnDrawGizmo : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        // 1. Set the color of your outline (e.g., green)
        Gizmos.color = Color.green;

        // 2. Get the BoxCollider attached to this object
        BoxCollider boxCollider = GetComponent<BoxCollider>();

        if (boxCollider != null)
        {
            // 3. Draw a wireframe cube matching the collider's position and size
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawWireCube(boxCollider.center, boxCollider.size);
        }
    }
}
