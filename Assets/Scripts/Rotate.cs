using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
     float speedX;
    [SerializeField] float speedY = 0.5f;
     float speedZ;


    void Update()
    {
        transform.Rotate(360 * speedX * Time.deltaTime, 360 * speedY * Time.deltaTime, 360 * speedZ * Time.deltaTime);

    }
}
