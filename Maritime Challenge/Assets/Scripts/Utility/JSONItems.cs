using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class JSONPlayerData
{
    public string sUsername;
    public bool bShowBirthday;
    public string dBirthday;
    public int iCurrentTitleID;
    public string sBiography;
    public int iLevel;
    public int iXP;
    public int iDepartment;
    public int iGuildID;
    public int iCountry;
    public int iTotalRightshipRollers;
    public int iTotalTokens;
    public int iTotalEventCurrency;
    public float fPlayerXPos;
    public float fPlayerYPos;
    public float fPlayerZPos;
}

[Serializable]
public class JSONPlayerDataList
{
    public List<JSONPlayerData> playerData = new List<JSONPlayerData>();
}

[Serializable]
public class JSONFriends
{
    public int iFriendUID;
    public int iFriendshipLevel;
}

[Serializable]
public class JSONFriendList
{
    public List<JSONFriends> friends = new List<JSONFriends>();
}

[Serializable]
public class JSONPhonebookData
{
    public int iOtherUID;
    public bool bOtherUnlocked;
}

[Serializable]
public class JSONPhonebookDataList
{
    public List<JSONPhonebookData> phonebookData = new List<JSONPhonebookData>();
}

[Serializable]
public class JSONFriendData
{
    public string sUsername;
    public bool bShowBirthday;
    public string dBirthday;
    public int iCurrentTitleID;
    public string sBiography;
    public int iLevel;
    public int iXP;
    public int iDepartment;
    public int iGuildID;
    public int iCountry;
    public bool bOnline;
}

[Serializable]
public class JSONFriendDataList
{
    public List<JSONFriendData> friendData = new List<JSONFriendData>();
}