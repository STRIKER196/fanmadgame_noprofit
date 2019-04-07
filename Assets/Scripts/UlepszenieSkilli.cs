using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UlepszenieSkilli : MonoBehaviour
{

    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public string level;
    int dzida;
    int lpg;
    int osad;
    int suma;
    int mobLevel;
    SpriteRenderer otherObjectRenderer;
    public Sprite tak;
    // Use this for initialization
    void Start()
    {
        dzida = PlayerPrefs.GetInt("dzida");
        lpg = PlayerPrefs.GetInt("lpg");
        osad = PlayerPrefs.GetInt("osad");
        mobLevel = PlayerPrefs.GetInt("mobLevel");
        HideElements();
        try
        {
            b4.SetActive(false);
        }
        catch { }

        if (mobLevel >= 9)
        {
            SetAll();
            HideElements();
            b4.SetActive(true);
        }
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
        //suma = dzida + lpg + osad;
        mobLevel += 1;
        PlayerPrefs.SetInt("mobLevel", mobLevel);
        Debug.Log(PlayerPrefs.GetInt("mobLevel").ToString());

        if (mobLevel >= 0 && mobLevel < 9)
        {
            SceneManager.LoadScene(level, LoadSceneMode.Single);
        }

        if (mobLevel >= 9)
        {
            SceneManager.LoadScene("BossLevel", LoadSceneMode.Single);
        }
    }
    void HideElements()
    {
        try
        {
            if (PlayerPrefs.GetInt("dzida") == 3) { b1.SetActive(false); }
        }
        catch { }
        try
        {
            if (PlayerPrefs.GetInt("lpg") == 3) { b2.SetActive(false); }
        }
        catch { }

        try
        {
            if (PlayerPrefs.GetInt("osad") == 3) { b3.SetActive(false); }
        }
        catch { }
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
