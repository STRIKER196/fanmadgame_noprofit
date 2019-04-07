using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AddSceneSingle : MonoBehaviour
{
    public string level;

    public void Start()
    {
        PlayerPrefs.SetInt("dzida", 0);
        PlayerPrefs.SetInt("lpg", 0);
        PlayerPrefs.SetInt("osad", 0);
        PlayerPrefs.SetFloat("cooldown", 0.8f);
        PlayerPrefs.SetFloat("enemyms",1.4f);
        PlayerPrefs.SetInt("mobLevel", 0);
    }
    void update() { }
    private void OnMouseDown()
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    }

}