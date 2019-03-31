using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour {

    int dzida;
    int lpg;
    int osad;
    public Sprite tak;
    public Sprite nie;
    SpriteRenderer otherObjectRenderer;
    // Use this for initialization
    void Start () {
        dzida = PlayerPrefs.GetInt("dzida");
        lpg = PlayerPrefs.GetInt("lpg");
        osad = PlayerPrefs.GetInt("osad");
        float enemyms = PlayerPrefs.GetFloat("enemyms");
        enemyms += 0.25f;
        PlayerPrefs.SetFloat("enemyms", enemyms);
        SetSkillsIcons();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    //najbardziej
    //gowniana
    //metoda
    //ever
    //prosze
    //tu
    //nie
    //zagladac
    void SetSkillsIcons() {
        setDzida();
        SetLpg();
        SetOsad();
    }

    void setDzida() {
        {
            string nazwa = "dzida";
            for (int i = 1; i < 4; i++)
            {
                otherObjectRenderer = GameObject.Find(nazwa + i.ToString()).GetComponent<SpriteRenderer>();
                otherObjectRenderer.sprite = nie;
            }
            if (dzida >= 1)
            {
                otherObjectRenderer = GameObject.Find("dzida1").GetComponent<SpriteRenderer>();
                otherObjectRenderer.sprite = tak;
            }
            if (dzida >= 2)
            {
                otherObjectRenderer = GameObject.Find("dzida2").GetComponent<SpriteRenderer>();
                otherObjectRenderer.sprite = tak;
            }
            if (dzida == 3)
            {
                otherObjectRenderer = GameObject.Find("dzida3").GetComponent<SpriteRenderer>();
                otherObjectRenderer.sprite = tak;
            }
        }
    }
    void SetLpg()
    {
        string nazwa = "lpg";
        for (int i = 1; i < 4; i++)
        {
            otherObjectRenderer = GameObject.Find(nazwa + i.ToString()).GetComponent<SpriteRenderer>();
            otherObjectRenderer.sprite = nie;
        }
        if (lpg >= 1)
        {
            otherObjectRenderer = GameObject.Find("lpg1").GetComponent<SpriteRenderer>();
            otherObjectRenderer.sprite = tak;
        }
        if (lpg >= 2)
        {
            otherObjectRenderer = GameObject.Find("lpg2").GetComponent<SpriteRenderer>();
            otherObjectRenderer.sprite = tak;
        }
        if (lpg == 3)
        {
            otherObjectRenderer = GameObject.Find("lpg3").GetComponent<SpriteRenderer>();
            otherObjectRenderer.sprite = tak;
        }
    }
    void SetOsad() {
        {
            string nazwa = "osad";
            for (int i = 1; i < 4; i++)
            {
                otherObjectRenderer = GameObject.Find(nazwa + i.ToString()).GetComponent<SpriteRenderer>();
                otherObjectRenderer.sprite = nie;
            }
            if (osad >= 1)
            {
                otherObjectRenderer = GameObject.Find("osad1").GetComponent<SpriteRenderer>();
                otherObjectRenderer.sprite = tak;
            }
            if (osad >= 2)
            {
                otherObjectRenderer = GameObject.Find("osad2").GetComponent<SpriteRenderer>();
                otherObjectRenderer.sprite = tak;
            }
            if (osad == 3)
            {
                otherObjectRenderer = GameObject.Find("osad3").GetComponent<SpriteRenderer>();
                otherObjectRenderer.sprite = tak;
            }
        }
    }
}
