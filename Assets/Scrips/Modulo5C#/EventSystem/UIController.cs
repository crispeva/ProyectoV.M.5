using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    #region Properties

    #endregion

    #region Fields
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _pointText;
    [SerializeField] private TextMeshProUGUI _levelText;
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
    public void UpdateSliderLife(float currentLife) {
        _slider.value = currentLife;
    }
    public void UpdatePoints(int  currentPoints)
    {
        _pointText.text = currentPoints.ToString();
    }
    public void UpdateLevel(int currentLevels)
    {
        _levelText.text = currentLevels.ToString();
    }
    #endregion

    #region Private Methods

    #endregion

}
