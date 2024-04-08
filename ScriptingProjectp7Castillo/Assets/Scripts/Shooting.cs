using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bullletSpeed;


    private Inventory inventory;

    void Awake()
    {
        inventory = GetComponent<Inventory>();
    }
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && inventory.myStuff.bullets > 0)
        {
            Rigidbody bullletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bullletInstance.AddForce(firePosition.forward * bullletSpeed);
            inventory.myStuff.bullets--;
        }
    }
}