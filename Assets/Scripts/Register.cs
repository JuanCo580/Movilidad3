using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO;
using TMPro;
public class Register : MonoBehaviour
{
    public TMP_InputField usernameInput, passwordInput;
    public Button registerButton, loginButton;
    public Animator transition;
    public GameObject textMessage;
    ArrayList credentials;
    void Start()
    {
        registerButton.onClick.AddListener(writeStuffToFile);
        loginButton.onClick.AddListener(LoginScene);

        if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            File.WriteAllText(Application.dataPath + "/credentials.txt", "");
        }
    }
    void LoginScene()
    {
        StartCoroutine(LoadLogin());
    }
    void writeStuffToFile()
    {
        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        foreach (var i in credentials)
        {
            if (i.ToString().Contains(usernameInput.text))
            {
                isExists = true;
                break;
            }
        }
        if (isExists)
        {
            Debug.Log($"Username '{usernameInput.text}' already exists");
        }
        else
        {
            credentials.Add(usernameInput.text + ":" + passwordInput.text);
            File.WriteAllLines(Application.dataPath + "/credentials.txt", (String[])credentials.ToArray(typeof(string)));
            Debug.Log("Account Registered");
            textMessage.SetActive(true);
        }
    }
    IEnumerator LoadLogin()
    {
        transition.SetBool("Activate Transition", true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Login");
        transition.SetBool("Activate Transition", false);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }

}