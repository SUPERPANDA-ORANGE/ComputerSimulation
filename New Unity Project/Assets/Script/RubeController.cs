using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // QualitySettings.vSyncCount = 0;
       // Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Debug.Log(hor);
        Vector2 pos = transform.position;
        pos.x = pos.x + 3.0f * hor*Time.deltaTime;
        pos.y = pos.y + 3.0f * ver*Time.deltaTime;
        transform.position = pos;
    }
}
