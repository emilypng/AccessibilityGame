using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // (player) set variable as the target, every object in a Scene has a Transform, used to store and manipulate the position, rotation and scale of object
    private Vector3 offset; // representation of 3D vectors and points, used to pass 3D positions and directions around

    void Start() // Start is called before the first frame update
    {
        offset = transform.position - target.position; // initialize offset, transform.position is used to get Vector3 of current game object
        
    }

    void LateUpdate()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, offset.z+target.position.z); // camera only needs to be different for z
        // transform.position = newPosition; <- less smooth
        transform.position = Vector3.Lerp(transform.position,newPosition, 0.6f); //lerp is parameter of vector3, Lerp is the point in between the from and to parameters
        
    }
}
