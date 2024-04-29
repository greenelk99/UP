using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] float cameraSpeed;

    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = player.transform.position.y - gameObject.transform.position.y - 1;
        Debug.Log(distanceToPlayer);
        if (distanceToPlayer > 0)
        {
            gameObject.transform.Translate(new Vector3(0, distanceToPlayer, 0) * Time.deltaTime * cameraSpeed);
        }
    }
}
