using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
public class PlayfabManager : MonoBehaviour
{
    public GameObject rowPrefab;
    public Transform rowsParent;
    public InputField userName;

   // Start is called before the first frame update
   void Start()
    {
        Login();
    }

    // Update is called once per frame
    public void Login()
    {
       
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            },
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request,OnSucces,OnError);

    }
    public void DisplayNameUpdate()
    {
        var request = new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = userName.text
        };
        PlayFabClientAPI.UpdateUserTitleDisplayName(request, OnDisplayNameUpdate, OnError);
    }
    public void OnDisplayNameUpdate(UpdateUserTitleDisplayNameResult res)
    {
        Debug.Log("USERNAME DEÐÝÞTÝ!!!");
    }
   

    void OnSucces(LoginResult result)
    {
        Debug.Log("SUCCES");

    }
    void OnError(PlayFabError error)
    {
        Debug.Log("FAIL");
        Debug.Log(error.GenerateErrorReport());
    }
    public void SendScore(int score)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName="Score",
                    Value= score
                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    }
    void OnLeaderboardUpdate(UpdatePlayerStatisticsResult res)
    {
        Debug.Log("Succesfull sent!");
    }
    public void GetLeaderboard()
    {
        var request = new GetLeaderboardRequest
        {
            StatisticName="Score",
            StartPosition=0,
            MaxResultsCount=10
        };
        PlayFabClientAPI.GetLeaderboard(request, OnleaderboardGet, OnError);
    }
    void OnleaderboardGet(GetLeaderboardResult res)
    {

       
        foreach(var item in res.Leaderboard)
        {
            GameObject newGo = Instantiate(rowPrefab,rowsParent);
            Text[] texts = newGo.GetComponentsInChildren<Text>();
            texts[0].text = item.DisplayName;
            texts[1].text = item.StatValue.ToString();
        }
        
    }
}
