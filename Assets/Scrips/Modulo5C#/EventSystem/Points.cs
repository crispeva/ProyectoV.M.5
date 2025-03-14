using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
 #region Properties
    public int CurrentPoints {  get; set; }
    public int CurrentLevel { get; set; }
    public event Action OnGetPoints;
    public event Action OnGetLevel;
    #endregion

    #region Fields

    #endregion

    #region Unity Callbacks
    void Start()
    {
        
    }
    #endregion

    #region Public Methods
    public void AddPoints (int pointsAdd) {
        CurrentPoints += pointsAdd;
        OnGetPoints?.Invoke();
    }
    public void AddLevel(int pointsAdd)
    {
        CurrentLevel += pointsAdd;
        OnGetLevel?.Invoke();
    }
    #endregion

    #region Private Methods

    #endregion

}
