using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform playerTransform;
    private float smoothing = 2f;


    void FixedUpdate()
    {
        Vector3 targetPosition = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);

    }
}
