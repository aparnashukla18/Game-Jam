using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 5f;
    public Vector3 offset = new Vector3(0f, 0f, -10f);
   

    
    void LateUpdate()
    {
        if(player == null)
        {
            return;

            Vector3 targetposition = player.position + offset;

            transform.position = Vector3.Lerp(transform.position, targetposition, smoothSpeed * Time.deltaTime);
        }
    }
}
