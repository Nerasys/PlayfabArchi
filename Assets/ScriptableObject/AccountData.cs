using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataAccount", menuName = "Account", order = 51)]
public class AccountData : ScriptableObject
{
    public string idPlayfab;
    private string username;
    public string mail;
    public string language;
    public string avatarURL;


    public void SetUsername(string _username)
    {
        username = _username;
    }

    public string GetUsername()
    {
        return username;
    }



}
