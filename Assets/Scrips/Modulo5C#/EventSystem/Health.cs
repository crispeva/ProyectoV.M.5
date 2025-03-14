using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
 #region Properties
    public float CurrentHealth {

        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
            //La variable "value" representa el valor que le van a setear o meter en otras funciones, etc.
            if (value < 0)
            {
                _currentHealth = 0;
                Die();
            }
            if(value > _maxHealth) 
                _currentHealth=_maxHealth;
        } 
            }
    //Se inicializan los eventos
    public event Action OnGetDamage;
    public event Action OnGetHeal;
    public event Action OnDie;
    #endregion

    #region Fields
    private float _currentHealth;
    [SerializeField] private float _maxHealth=100;
    [SerializeField] private bool _die=false;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        _currentHealth=_maxHealth;

    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (_die)
    //    {
    //        Die();
    //    }
    //}
    #endregion

    #region Public Methods
    public void GetDamage(float damage)
    {
        if (!_die)
        {
            CurrentHealth -= damage;
            //Llamamos al evento
            OnGetDamage?.Invoke();
        }
    }
    public void GetHeal(float life)
    {
        if (!_die)
        {
            CurrentHealth += life;
            //En esta llamada al evento si no tuviera la interrogacion fallaria al no tener ningun evento activo
            OnGetHeal?.Invoke();
        }
    }
    #endregion

    #region Private Methods
    private void Die()
    {
        
            _die = true;
            OnDie?.Invoke();
        
        
    }
    #endregion
  
}
