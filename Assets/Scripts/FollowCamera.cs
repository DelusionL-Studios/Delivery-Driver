using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float zOffset;

    void LateUpdate()
    {
        Vector3 newCameraPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - zOffset);

        transform.position = newCameraPos;  
    }
}
