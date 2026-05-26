using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{
    public float speed = 2f;
    public Transform camera;

    public float xoffset = 1f;

    private void Update()
    {   
        Vector3 newPos = new Vector3(camera.position.x + xoffset, camera.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, speed * Time.deltaTime);
    }

}