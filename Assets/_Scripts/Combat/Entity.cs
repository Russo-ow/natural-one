using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {


    #region Health
    [Header("Health")]
    [SerializeField] protected int health;

    public virtual void TakeDamage(int damage) {
        // Apply Damage
        health -= damage;

        // Check for death
        if (health <= 0) {
            Die();
        } 
    }

    protected virtual void Die() {
        // TODO
    }

    #endregion
}