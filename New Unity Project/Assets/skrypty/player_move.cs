using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public float playerspeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * playerspeed, Input.GetAxis("Vertical") * Time.deltaTime * playerspeed, 0);
    }
}
