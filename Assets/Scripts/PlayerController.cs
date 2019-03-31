using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public int skillPoints = 0;
    public int u_dzida = 0;
    public int u_lpg = 0;
    public int u_osad = 0;
    public int levelPoints = 0;
    public GameObject score;
    private Text textPoints;

	// Use this for initialization
	void Start () {
        textPoints = score.GetComponent<Text>();
        textPoints.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UlepszDzide() {
        if (skillPoints > 0)
        {
            if (u_dzida < 3)
            {
                u_dzida += 1;
                skillPoints -= 1;
            }
        }
    }

    public void UlepszLpg()
    {
        if (skillPoints > 0)
        {
            if (u_lpg < 3)
            {
                u_lpg += 1;
                skillPoints -= 1;
            }
        }
    }

    public void UlepszOsad()
    {
        if (skillPoints > 0)
        {
            if (u_osad < 3)
            {
                u_osad += 1;
                skillPoints -= 1;
            }
        }
    }

    public void DodajPunktUmiejetnosci() {
        skillPoints += 1;
    }

    public void DodajPunktyPoziomu(int ileDodac) {
        levelPoints += ileDodac;
        textPoints.text = "Score: " + levelPoints.ToString() + "/100";
    }
}
