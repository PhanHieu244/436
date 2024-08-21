using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeadboardObject : MonoBehaviour {
    public Image icon;
    public Text place;
    public Text playerName;
    public Text score;
#if PLAYFAB
    private LeadboardPlayerData playerData;

    public LeadboardPlayerData PlayerData {
        get {
            return playerData;
        }

        set {
            playerData = value;
            SetupIcon();
        }
    }

    void SetupIcon() {
        icon.sprite = PlayerData.picture;
        place.text = "" + PlayerData.position;
        playerName.text = PlayerData.Name;
        score.text = "" + PlayerData.score;
        if (PlayFabManager.THIS.IsYou(PlayerData.PlayFabId)) {
            playerName.text = "YOU";
            playerName.color = Color.red;
            //if (LevelManager.THIS.gameStatus == GameState.Win) {
            //    score.text = "" + PlayerPrefs.GetInt("Score" + LevelManager.THIS.currentLevel);
            //   }
        }
    }

#endif

}
