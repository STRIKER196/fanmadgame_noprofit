using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScene : MonoBehaviour
{
    public void Start()
    {
    }
    void update() { }
    private void OnMouseDown()
    {
        SceneManager.LoadScene("BossScene", LoadSceneMode.Single);
    }
}

