using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlattformSkript : MonoBehaviour
{
    public float fallSpeed;

    void Start()
    {
        fallSpeed = 0.5f;
    }

    void Update()
    {
        transform.Translate(new Vector3(0, -fallSpeed, 0) * Time.deltaTime);
    }

}
