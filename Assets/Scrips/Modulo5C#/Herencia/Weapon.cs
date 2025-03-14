using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Inventario
{
    [Serializable]
    public class Weapon : Item, IUsable
    {
        #region Properties
        [field: SerializeField] public int damage { get; set; }
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

        }
        #endregion

        #region Public Methods
        public void Attack()
        {
            Debug.Log("Atacando con el arma: " + name);
        }

        public void Use()
        {
            Debug.Log("Usando el arma: " + name);

        }
        #endregion

        #region Private Methods

        #endregion

    }
}