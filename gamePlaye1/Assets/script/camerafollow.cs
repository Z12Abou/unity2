
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;
    public float speed = 0.05f;
    public Vector3 offset;
    private void LateUpdate()
    {
        Vector3 positionlmrghoba = player.position + offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position, positionlmrghoba, speed);
        transform.position =smoothposition ;
        transform.LookAt(player);
    }
}
