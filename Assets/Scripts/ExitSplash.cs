using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitSplash : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(Example());      
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(7f);
        Exit();
    }
    private void Exit()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}