using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PutimScript : MonoBehaviour {

    public GameObject Katana;
    public GameObject Explosion;
    public int bossHp = 150;
    float lastFireTime;
    public float fireCooldown = 0.5f;
    private List<GameObject> topkek = new List<GameObject>();
    // Use this for initialization
    void Start () {
	}

    private void Update()
    {
        /*Shoot();
        foreach(var katana in topkek)
        {
            katana.transform.Rotate(new Vector3(10, 0));
        }*/
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Laser")
        {
            if (other.transform.parent != null)
            {
                Destroy(other.transform.parent.gameObject);
            }
            Destroy(other.gameObject);
            TakeHp(1);
        }
        if (bossHp <= 0)
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            SceneManager.LoadScene("WinnerScene", LoadSceneMode.Single);
        }
    }

    void Shoot()
    {
        if (lastFireTime + fireCooldown < Time.time)
        {
            Instantiate(Katana, Katana.transform.position = new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            topkek.Add(Katana);
            lastFireTime = Time.time;
        }

    }

    private void TakeHp(int damage)
    {
        bossHp -= damage;
    }
}


