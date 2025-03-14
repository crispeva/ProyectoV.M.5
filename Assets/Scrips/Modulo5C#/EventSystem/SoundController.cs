using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    #region Properties

    #endregion

    #region Fields
    [SerializeField] private AudioClip _damageSound;
    [SerializeField] private AudioClip _sound;
    private AudioSource _audioSource;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region Public Methods

    #endregion

    #region Private Methods
    public void PlayDamageSound()
    {
        _audioSource.clip= _damageSound;
        _audioSource.Play();
    }
    public void PlayDieSound()
    {
        _audioSource.clip = _sound;
        _audioSource.Play();
    }
    #endregion

}
