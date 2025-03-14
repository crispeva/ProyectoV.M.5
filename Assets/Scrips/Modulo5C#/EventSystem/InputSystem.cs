using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    #region Properties
    public event Action OnKeyDamage;
    public event Action OnKeyHeal;
    public event Action OnKeyPoints;
    public event Action OnKeyLevel;

    //public event Action OnKeyAddLevel;
    #endregion

    #region Fields

    #endregion

    #region Unity Callbacks
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KeyDamage();
        KeyHeal();
        KeyPoints();
        KeyAddLevel();

    }
    #endregion

    #region Public Methods
    public void KeyDamage()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            OnKeyDamage?.Invoke();
        }
    }
    public void KeyHeal()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            OnKeyHeal?.Invoke();
        }
    }
    public void KeyPoints()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            OnKeyPoints?.Invoke();
        }
    }
    public void KeyAddLevel()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            OnKeyLevel?.Invoke();
        }
    }
    #endregion

    #region Private Methods

    #endregion

}
