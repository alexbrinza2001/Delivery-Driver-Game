using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject car;
    void LateUpdate()
    {
        transform.position = new Vector3(car.transform.position.x, car.transform.position.y, -10);
    }
}
