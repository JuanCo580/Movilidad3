using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCarController : MonoBehaviour
{
    public GameObject vgVoice, pauseMenu, level;
    public AudioSource startCar;
    public AudioClip soundCar;
    public CarController carController;
    public TextMeshProUGUI time, score, timeResult, scoreResult;
    
    public bool r;
    public static bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        vgVoice.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            carController.enabled = true;
            StartCoroutine(CarStart());
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        timeResult.text = "Tiempo:" + time.text;
        scoreResult.text = "Puntaje:" + score.text;
    }

    IEnumerator CarStart()
    {
        startCar.enabled = true;
        yield return new WaitForSeconds(1);
        startCar.clip = soundCar;
        startCar.Play();
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        //level.SetActive(false);
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        //level.SetActive(true);
    }
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Login");
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
