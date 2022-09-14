using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class TitleScreenManager : MonoBehaviour
{
    // Encapsulation
    [SerializeField] private Button startButton, exitButton;
    [SerializeField] private AudioClip cursor_SFX;
    [SerializeField] private AudioClip select_SFX;
    [SerializeField] private Animator fadeScreen;
    private AudioSource audioSource;
    private bool isLoading;

    void Awake()
    {
        isLoading = false;
        audioSource = gameObject.GetComponent<AudioSource>();

        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
    }


    // Abstraction
    void StartGame()
    {
        if (!isLoading)
        {
            PlaySelectSFX();
            StartCoroutine(LoadScene());            
        }
    }

    // Abstraction
    private IEnumerator LoadScene()
    {
        isLoading = true;
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);
        Debug.Log("Scene Loaded");
    }

    // Abstraction
    void ExitGame()
    {
        if(!isLoading)
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif     
    }

    // Abstraction
    public void PlayCursorSFX()
    {
        if (!isLoading)
        audioSource.PlayOneShot(cursor_SFX);
    }

    // Abstraction
    void PlaySelectSFX()
    {
        if(!isLoading)
        audioSource.PlayOneShot(select_SFX);
    }
}
