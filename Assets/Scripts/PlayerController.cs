using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

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
        if (levelPoints >= 20) {
            OtworzSklep();
        }
	}

    public void DodajPunktyPoziomu(int ileDodac) {
        levelPoints += ileDodac;
        textPoints.text = "Score: " + levelPoints.ToString() + "/100";
    }

    public void OtworzSklep() {
        SceneManager.LoadScene("Sklep", LoadSceneMode.Single);
    }
}
