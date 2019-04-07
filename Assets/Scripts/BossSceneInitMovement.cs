using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSceneInitMovement : MonoBehaviour {

    public GameObject player;
    public GameObject playerSpriteOnly;
    public GameObject putin;
    public GameObject putinSpriteOnly;
    public GameObject[] life;
    // Use this for initialization
    void Start () {
        DisableAllLifeIcons();
        player.SetActive(false);
        putin.SetActive(false);
        StartCoroutine(waiter());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(7f);
        playerSpriteOnly.SetActive(false);
        player.SetActive(true);
        putinSpriteOnly.SetActive(false);
        putin.SetActive(true);
    }

    private void DisableAllLifeIcons()
    {
        foreach (GameObject l in life)
        {
            l.SetActive(false);
        }
    }

}
