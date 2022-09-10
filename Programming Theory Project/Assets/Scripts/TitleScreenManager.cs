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
    [SerializeField] private Button startButton, exitButton;
    [SerializeField] private AudioClip cursor_SFX;
    [SerializeField] private AudioClip select_SFX;
    [SerializeField] private Animator fadeScreen;
    private AudioSource audioSource;
    private bool isLoading;

    void Start()
    {
        isLoading = false;
        audioSource = gameObject.GetComponent<AudioSource>();

        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    void StartGame()
    {
        if (!isLoading)
        {
            PlaySelectSFX();
            StartCoroutine(LoadScene());            
        }
    }

    private IEnumerator LoadScene()
    {
        isLoading = true;
        fadeScreen.SetTrigger("Trigger_FadeOut");
        yield return new WaitForSeconds(1.5f);
        Debug.Log("Scene Loaded");
    }

    void ExitGame()
    {
        if(!isLoading)
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif     
    }

    public void PlayCursorSFX()
    {
        if (!isLoading)
        audioSource.PlayOneShot(cursor_SFX);
    }

    void PlaySelectSFX()
    {
        if(!isLoading)
        audioSource.PlayOneShot(select_SFX);
    }
}
