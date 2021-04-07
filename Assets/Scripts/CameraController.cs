using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //follow point is the point at which the camera will follow (in this case it's our character sprite).
    public Transform followPoint;

    //offset will keep the camera in front of the sprite.
    public Vector3 offset;

    //For our Lerp, this will tell us how much we want our camera movement smoothed by.
    [Range(2,10)] public float smoothingRate;

    private void FixedUpdate()
    {
        Follow();        
    }


    void Follow()
    {
        Vector3 targetPosition = followPoint.position + offset;

        /** We lerp from our target position, to the new position with smoothing. 
         * We use fixedDeltaTime here to make the rate the same on every machine, regardless of the fps. **/
        Vector3 positionSmoothing = Vector3.Lerp(transform.position, targetPosition, smoothingRate*Time.fixedDeltaTime);

        transform.position = positionSmoothing;
    }

}
