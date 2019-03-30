using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movmnent_Controller : MonoBehaviour
{
    public int speed = 10;
    public GameObject Katana;

    public float canFire = 0.0f;
    public float fireRate = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    void Movement()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * HorizontalInput * speed * Time.deltaTime);

        if (transform.position.x < -9)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-9, transform.position.y, 0);
        }
    }
    void Shoot()
    {
        if (Time.time > canFire)
        Instantiate(Katana, Katana.transform.position = new Vector3(transform.position.x + 0.35f, transform.position.y + 3.15f, 0), Quaternion.identity);
        canFire = Time.time + fireRate;
    }
}
