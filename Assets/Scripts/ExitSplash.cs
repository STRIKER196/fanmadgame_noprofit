using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitSplash : MonoBehaviour {

    public string level;
    public float time;
	// Use this for initialization
	void Start () {

        StartCoroutine(Example());      
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(time);
        Exit();
    }
    private void Exit()
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    }
}