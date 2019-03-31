using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class Movmnent_Controller : MonoBehaviour
{
    int dzida;
    int lpg;
    int osad;
    GameObject[] spawners;

    public int speed = 10;
    public GameObject Katana;
    float lastFireTime;
    public float fireCooldown = 1f;
    public float hp = 200f;

    public GameObject Explosion;

    // Start is called before the first frame update
    void Start()
    {
        lastFireTime = Time.time;
        transform.position = new Vector3(0, -4, 0);
        dzida = PlayerPrefs.GetInt("dzida");
        lpg = PlayerPrefs.GetInt("lpg");
        osad = PlayerPrefs.GetInt("osad");
        speed = speed + lpg * 3;
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        foreach (GameObject s in spawners) {
            s.SetActive(false);
        }
        StartCoroutine(WaitForSpawners());
    }

    IEnumerator WaitForSpawners()
    {
        print(Time.time);
        yield return new WaitForSeconds(3f);
        EnableSpawners();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        if (hp == 100)
        {
            GameObject.Find("life2").SetActive(false);
        }
        if (hp == 200)
        {
            GameObject.Find("life3").SetActive(false);
        }
        if (hp == 300)
        {
            GameObject.Find("life1").SetActive(true);
            GameObject.Find("life2").SetActive(true);
            GameObject.Find("life3").SetActive(true);
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
        if (lastFireTime + fireCooldown <= Time.time)
        {
            Instantiate(Katana, Katana.transform.position = new Vector3(transform.position.x + 0.35f, transform.position.y + 3.15f, 0), Quaternion.identity);
            PlaySound();
            lastFireTime = Time.time;
        }
        
    }
    void PlaySound() {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }
    public void Damage()
    {
        hp -= 100;

        if (hp < 1)
        {
            GameObject.Find("life1").SetActive(false);
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
        }
    }

    private void EnableSpawners() {
        foreach (GameObject s in spawners)
        {
            s.SetActive(true);
        }
    }
}
