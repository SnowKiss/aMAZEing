using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        player = GameObject.Find("/Player");
        //Debug.Log(player.transform.position);
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        Vector3 vect = new Vector3(player.transform.position.x + offset.x, transform.position.y, transform.position.z);
        transform.position=vect;
        //Debug.Log(vect);
    }
}