using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    //[SerializeField]
    //private Vector2 parallaxMultiplier;

    private Transform cameraTransform;
    private Vector3 lastCameraPosition;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.position += new Vector3(deltaMovement.x * Random.Range(-1, 1), deltaMovement.y * parallaxMultiplier.y);
        lastCameraPosition = cameraTransform.position;
    }
}