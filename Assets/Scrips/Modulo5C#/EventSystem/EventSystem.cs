using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    #region Properties

    #endregion

    #region Fields
    //Inicializamos los componenentes que vayamos a utilizar
    [SerializeField] private Points _points;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private UIController _ui;
    [SerializeField] private SoundController _sound;
    [SerializeField] private InputSystem _input;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        //Escucho a los siguientes eventos, si se ejecutan, llamo a los eventos de la derecha
        _playerHealth.OnDie += OnDie;
        _input.OnKeyDamage += OnGetDamage;
        _input.OnKeyHeal += OnGetHeal;
        _input.OnKeyPoints += OnAddPoints;
        _input.OnKeyLevel += OnAddLevel;
    }
    #endregion

    #region Public Methods

    #endregion

    #region Private Methods
    //Son metodos que llaman a otro eventos con el mismo contexto
    private void OnGetDamage() {
        _playerHealth.GetDamage(20);
        _ui.UpdateSliderLife(_playerHealth.CurrentHealth);
        _sound?.PlayDamageSound();
    }

    private void OnDie()
    {
       _sound?.PlayDieSound();
        Debug.Log("Player DIE!");
        Destroy(_playerHealth.gameObject);
    }
    private void OnGetHeal()
    {
        _playerHealth.GetHeal(20);
        _ui.UpdateSliderLife(_playerHealth.CurrentHealth);
        

    }
    private void  OnAddPoints()
    {
        _points.AddPoints(100);
        _ui.UpdatePoints(_points.CurrentPoints);
    }
    private void OnAddLevel()
    {
        _points.AddLevel(1);
        _ui.UpdateLevel(_points.CurrentLevel);
    }
    #endregion

}
