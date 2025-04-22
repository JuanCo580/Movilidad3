using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Login : MonoBehaviour
{
    public TMP_InputField usernameInput, passwordInput;
    public Button loginButton, registerButton;
    public Animator transition;
    public GameObject registerMessage;
    ArrayList credentials;
    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(login);
        registerButton.onClick.AddListener(moveToRegister);

        if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            Debug.Log("Credential file doesn't exist");
        }
    }
    void login()
    {
        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));

        foreach (var i in credentials)
        {
            string line = i.ToString();
            if (i.ToString().Substring(0, i.ToString().IndexOf(":")).Equals(usernameInput.text) &&
                i.ToString().Substring(i.ToString().IndexOf(":") + 1).Equals(passwordInput.text))
            {
                isExists = true;
                break;
            }
        }
        if (isExists)
        {
            Debug.Log($"Logging in '{usernameInput.text}'");
            loadLoadingScreen();
        }
        else
        {
            Debug.Log("Incorrect credentials");
            registerMessage.SetActive(true);
        }
    }
    void moveToRegister()
    {
        StartCoroutine(LoadMoveToRegister());
    }
    void loadLoadingScreen()
    {
        StartCoroutine(LoadingScreen());
    }
    IEnumerator LoadMoveToRegister()
    {
        transition.SetBool("Activate Transition", true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Register");
        transition.SetBool("Activate Transition", false);
    }
    IEnumerator LoadingScreen()
    {
        transition.SetBool("Activate Transition", true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("LoadingScreen");
        transition.SetBool("Activate Transition", false);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }

}
