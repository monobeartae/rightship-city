using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviourSingleton<TutorialManager>
{
    private Tutorial[] tutorialList;

    private Tutorial currentTutorial;

    private int tutorialPhase = 0;

    void ActivateNextPhase()
    {
        tutorialPhase++;
        currentTutorial = tutorialList[tutorialPhase];
    }

    public void SkipTutorial()
    {
        PlayerData.CommandsHandler.SwitchSubScene("WorldHubScene", SceneManager.StartWorldHubSpawnPos);
    }
}
