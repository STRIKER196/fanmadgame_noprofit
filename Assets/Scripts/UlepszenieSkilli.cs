using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UlepszenieSkilli : MonoBehaviour
{

    GameObject b1;
    GameObject b2;
    GameObject b3;
    GameObject b4;
    public string level;
    int dzida;
    int lpg;
    int osad;
    int suma;
    SpriteRenderer otherObjectRenderer;
    public Sprite tak;
    // Use this for initialization
    void Start()
    {
        b1 = GameObject.Find("ulepsz_dzida");
        b2 = GameObject.Find("ulepsz_lpg");
        b3 = GameObject.Find("ulepsz_osad");
        b4 = GameObject.Find("boss");
        dzida = PlayerPrefs.GetInt("dzida");
        lpg = PlayerPrefs.GetInt("lpg");
        osad = PlayerPrefs.GetInt("osad");
        HideElements();
        b4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (gameObject.name == "ulepsz_dzida") { dzida += 1; PlayerPrefs.SetInt("dzida", dzida); }
        if (gameObject.name == "ulepsz_lpg") { lpg += 1; PlayerPrefs.SetInt("lpg", lpg); }
        if (gameObject.name == "ulepsz_osad") { osad += 1; PlayerPrefs.SetInt("osad", osad); }
        suma = dzida + lpg + osad;
        if (suma < 9)
        {
            SceneManager.LoadScene(level, LoadSceneMode.Single);
        }
        else
        {
            HideElements();
            b4.SetActive(true);
            SetAll();
        }
        if (gameObject.name == "boss") { SceneManager.LoadScene("boss", LoadSceneMode.Single); }
    }
    void HideElements()
    {
        if (dzida == 3) { b1.SetActive(false); }
        if (lpg == 3) { b2.SetActive(false); }
        if (osad == 3) { b3.SetActive(false); }
    }

    void SetAll()
    {
        {
            otherObjectRenderer = GameObject.Find("dzida3").GetComponent<SpriteRenderer>();
            otherObjectRenderer.sprite = tak;
            otherObjectRenderer = GameObject.Find("lpg3").GetComponent<SpriteRenderer>();
            otherObjectRenderer.sprite = tak;
            otherObjectRenderer = GameObject.Find("osad3").GetComponent<SpriteRenderer>();
            otherObjectRenderer.sprite = tak;
        }
    }
}
