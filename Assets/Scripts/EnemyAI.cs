using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyExplosionPrefab;
    public GameObject enemy;
    private float _speed = 1.4f;

    GameObject player;
    PlayerController pc;


    // Start is called before the first frame update
    void Start()
    {
        //guzik.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player");
        pc = player.GetComponent<PlayerController>();
        _speed = PlayerPrefs.GetFloat("enemyms");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Laser")
        {
            if (other.transform.parent != null)
            {
                Destroy(other.transform.parent.gameObject);
            }
            Destroy(other.gameObject);
            Instantiate(_enemyExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            pc.DodajPunktyPoziomu(1);
        }
        else if (other.tag == "Player")
        {
             Movmnent_Controller player = other.GetComponent<Movmnent_Controller>();

            if (player != null)
            {
                player.Damage();
            }
            Instantiate(_enemyExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);


        }
    }
}