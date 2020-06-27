using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [Header("Pannel Connex")]
    [SerializeField] GameObject loginPanel;
    [SerializeField] GameObject registerPanel;

    [Header("Login Connex")]
    [SerializeField] InputField usernameLogin;
    [SerializeField] InputField passwordLogin;

    [Header("Register Connex")]
    [SerializeField] InputField usernameRegister;
    [SerializeField] InputField passwordRegister;
    [SerializeField] InputField mailRegister;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void BackToLogin()
    {
        registerPanel.SetActive(false);
        loginPanel.SetActive(true);
    }

    public void GoToRegister()
    {
        registerPanel.SetActive(true);
        loginPanel.SetActive(false);
    }

    public void ButtonLogin()
    {
    //    PlayfabInterface.instance.LoginUnity();
     
    }

    public void ButtonRegister()
    {
       PlayfabInterface.instance.RegisterUnity(usernameRegister.text, passwordRegister.text, mailRegister.text);
    }













}
