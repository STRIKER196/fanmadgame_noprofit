using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicFade : MonoBehaviour
{
    public string level;
    public string alternativeLevel;
    public float fadeOutTime = 2f;


    AudioSource audioSource;
    bool fading;
    float fadePerSec;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Debug.Assert(audioSource != null);

        Object.DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void Update()
    {
        if (fading)
        {
            audioSource.volume = Mathf.MoveTowards(
                audioSource.volume, 0, fadePerSec * Time.deltaTime);
        }
    }


    void OnSceneLoaded(Scene loadedScene, LoadSceneMode mode)
    {
        if (SceneManager.GetActiveScene().name == level || SceneManager.GetActiveScene().name == alternativeLevel)
        {
            fading = true;
            fadePerSec = audioSource.volume / fadeOutTime;
            Destroy(gameObject, fadeOutTime);
        }
    }
}