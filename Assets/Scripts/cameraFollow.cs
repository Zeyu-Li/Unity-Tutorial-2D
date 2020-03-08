using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    // selects targe to be fixed on
    public Transform target;
    public float smoothing = 0.12f;

    // because it is fixed to player, we want to move in from by 10 layers be default
    public Vector3 offset = new Vector3(0f,0f,-10f);

    void FixedUpdate() {
        Vector3 desiredP = target.position + offset;

        // interpolate movement
        Vector3 smoothP = Vector3.Lerp(transform.position, desiredP, smoothing);
        transform.position = smoothP;

        // will move in direction of target
        // comment out if you don't like the jitters
        transform.LookAt(target);
    }

}
