using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float timeFix = 0f;
    float timer;


    // Update is called once per frame
    void Update()
    {
        timer = Time.time - timeFix;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& timer > 2f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeFix = Time.time;
            Debug.Log(timer.ToString());
        }
    }


}
