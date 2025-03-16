using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Inventario
{
    [Serializable]
    public class Others : Item, ISeable
    {
        #region Properties
        [field: SerializeField] public float Price { get; set; }
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
        public float Sell()
        {
            Debug.Log("Has ganado: " + Price + " dineritos!");
            return Price;
        }
        #endregion

        #region Private Methods

        #endregion

    }
}
