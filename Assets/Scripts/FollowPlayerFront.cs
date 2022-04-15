using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerFront : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTransform;
    private Vector3 cameraOffset;

    void Start()
    {
        cameraOffset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = playerTransform.position + cameraOffset;
        transform.position = newPos;
    }
}
