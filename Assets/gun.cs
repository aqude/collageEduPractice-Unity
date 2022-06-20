using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform shotPoint;
    public GameObject bullet;
    private float timeBtwShots;
    public float StartTimeBtwShots;
    public float offset;

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        if (timeBtwShots <= 0) {
            if (Input.GetMouseButton(0)) {
                Instantiate(bullet, shotPoint.position, transform.rotation);
                timeBtwShots = StartTimeBtwShots;
            }
        }
        else {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
