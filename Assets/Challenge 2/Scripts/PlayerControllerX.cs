using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool intervalShoot;
    private float intervalTime = 1f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !intervalShoot)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            intervalShoot = true;
            Invoke("IntervalShootTime", intervalTime);
        }
    }

    private void IntervalShootTime()
    {
        intervalShoot = false;
    }
}
