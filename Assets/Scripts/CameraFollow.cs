using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public int smoothSpeed;
    public float minX;
    public float maxX;

    public float minY;
    public float maxY;

    public float cameraZ;

    void Start()
    {
        
    }
    public void LateUpdate()
    {
        if(player == null)
        {
            return;
        }
        float targetX = Mathf.Clamp(player.position.x, minX, maxX);

        float targetY = Mathf.Clamp (player.position.y, minY, maxY);

        Vector3 targetposition = new Vector3(targetX, targetY, cameraZ);

        transform.position = Vector3.Lerp(transform.position, targetposition, smoothSpeed);
    }

}
