using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Inventario;
using TMPro;
public class ItemButton : MonoBehaviour
{
    #region Properties
    //Propiedad para obtener el item actual
    public Item  Current_Item {
        get
        {
            return _currentItem;
        }

        set
        {
            //Se asigna el valor al item actual
            _currentItem = value;
            _textButton.text = _currentItem.name;
            
        }

        }
    public Action OnClick;
    #endregion

    #region Fields
    private TextMeshProUGUI _textButton;
    private Button _button;
    private Item _currentItem;
    #endregion

    #region Unity Callbacks
    void Awake()
    {
        _button = GetComponent<Button>();
        //Obtener el componente de texto
        _textButton = GetComponentInChildren<TextMeshProUGUI>();
        //Asignar el evento al boton
        _button.onClick.AddListener(()=> OnClick?.Invoke());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region Public Methods

    #endregion

    #region Private Methods

    #endregion

}
