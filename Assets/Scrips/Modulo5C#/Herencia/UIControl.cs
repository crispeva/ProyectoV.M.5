using System;
using System.Collections;
using System.Collections.Generic;
using Inventario;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
public class UIControl : MonoBehaviour
{
    #region Properties
    [field:SerializeField] public Button UseButton { get; set; }
    [field: SerializeField] public Button SellButton { get; set; }
    [field: SerializeField] public Transform InventoryPanel { get; set; }
    #endregion

    #region Fields
    #endregion

    #region Unity Callbacks
     void Start()
    {
        
    }
    #endregion

    #region Public Methods
    #endregion
    //Funcion dependiedo del item seleccionado se activan o desactivan los botones de acciones
    public void SellCurrentItem(ItemButton _currentItemSelected)
    {
        //Se llama a la funcion de vender del item seleccionado
        if (_currentItemSelected != null)
        {
            (_currentItemSelected.Current_Item as ISeable).Sell();
           
            ConsumeItem(_currentItemSelected);
            
        }

    }
    //Refactor
    public void UseCurrentItem(ItemButton _currentItemSelected)
    {
        if (_currentItemSelected != null)
        {
            (_currentItemSelected.Current_Item as IUsable).Use();
            if (_currentItemSelected.Current_Item is IConsumable)
            {
                ConsumeItem(_currentItemSelected);
            }
        }
    }
    #region Private Methods

    private void ConsumeItem(ItemButton current_Item)
    {
        if (current_Item != null) { 
            Destroy(current_Item.gameObject);
            current_Item = null;
        }

    }

    #endregion

}
