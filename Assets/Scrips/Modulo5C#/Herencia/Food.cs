using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Se indica de esta manera englobando todo el script
namespace Inventario
{
    public interface IConsumable { }

    [Serializable]
    public class Food : Item, IUsable, ISeable,IConsumable
    {
        #region Properties
        [field: SerializeField] public float Price { get; set; }
        [field: SerializeField] public float HealingPoints { get; set; }
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
            Debug.Log("Has ganado: " + Price + "dineritos!");
            return Price;
        }

        public void Use()
        {
            Debug.Log("Comiendo: " + name + "y ganas" + HealingPoints + "puntos de vida recuperados");

        }
        #endregion

        #region Private Methods

        #endregion

    }
}