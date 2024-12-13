using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootyGunScript : MonoBehaviour
{
    [SerializeField] public InputActionReference shootButton;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private float bulletLife = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
        shootButton.action.started += shoot;
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    void shoot(InputAction.CallbackContext context){
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            // activate the bullet
            bullet.SetActive(true);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
            // destroy the bullet after bulletLife seconds
            Destroy(bullet, bulletLife);
    }
}
