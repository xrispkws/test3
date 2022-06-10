using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private Vector3 origin_cam_pos;
    private void Start()
    {
        origin_cam_pos = transform.position;
    }

    private void Update()
    {
        Vector3 next_pos = new Vector3(player.position.x, 0f, player.position.z);
        transform.position = origin_cam_pos + next_pos;
    }
}
