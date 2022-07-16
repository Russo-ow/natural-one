using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    void Awake() {
        // Singleton Setup
        if (Instance != null) {
            Debug.LogError("Multiple GameManager Instances");
        }
        Instance = this;
    }

    #region Combat
    private Friendly[] friendlies = new Friendly[4];
    private Enemy[] enemies = new Enemy[4];

    public void SetPosition(int position) {

    }
    #endregion

    #region Gold
    private int gold;

    // Probably dont need
    public int GetGold() {
        return gold;
    }

    public void AddGold(int addGold) {
        gold += addGold;

        // TODO Update UI
    }

    // Can get rid of check for efficiency if buttons are disabled if player does not have enough gold
    public bool TryPurchace(int cost) {
        if (gold >= cost) {
            gold -= cost;

            // TODO Update UI

            return true;
        }
        return false;
    }

    // Returns true if player can afford cost, false otherwise - does not spend gold
    public bool CanPurchace(int cost) {
        return gold >= cost;
    }

    #endregion

}
