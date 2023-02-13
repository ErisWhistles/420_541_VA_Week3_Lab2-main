using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMechanics : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject BulletSpawnPoint;

    private float totalCharge = 0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")){
            totalCharge += 0.01f;
            Debug.Log(totalCharge);
        }
        if(Input.GetButtonUp("Fire1")){
            var bullet = Instantiate(Bullet, BulletSpawnPoint.transform.position, BulletSpawnPoint.transform.rotation);
            var rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = BulletSpawnPoint.transform.forward * totalCharge;

            
            totalCharge = 0;
            Destroy(bullet, 5);
        }
    }
}
