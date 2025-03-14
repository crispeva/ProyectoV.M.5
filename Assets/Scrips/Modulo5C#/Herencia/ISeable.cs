using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Inventario
{
    public interface ISeable
    {
        #region Properties
        public float Price { get; set; }
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
        public float Sell();
        #endregion

        #region Private Methods

        #endregion

    }
}