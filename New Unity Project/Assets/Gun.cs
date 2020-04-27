
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float count = 0f;
    public float range = 100f;

    public Camera fpsCam;
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }

    void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range);
    }


}
