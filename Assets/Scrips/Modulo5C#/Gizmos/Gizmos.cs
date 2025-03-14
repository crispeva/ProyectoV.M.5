using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmos : MonoBehaviour
{
    #region Properties

    #endregion

    #region Fields
    [Header("Initial Gizmo Line")]
    [SerializeField] private Vector3 initialGizmoLine;
    [Header("Final Gizmo Line")]
    [SerializeField] private Vector3 finalGizmoLine;
    [Header("Vision rangue")]
    [SerializeField] private float _visionlentgh=10;
    [Header("Audio rangue")]
    [SerializeField] private float _audiolentgh=30;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        OnDrawGizmos();
    }

    // Update is called once per frame
    #endregion

    #region Public Methods

    #endregion

    #region Private Methods
    private void OnDrawGizmos()
    {
        UnityEngine.Gizmos.color = Color.white;
        UnityEngine.Gizmos.DrawLine(initialGizmoLine, finalGizmoLine);
        UnityEngine.Gizmos.DrawSphere(Vector3.zero, _visionlentgh);
        UnityEngine.Gizmos.color = Color.red;
        UnityEngine.Gizmos.DrawLine(Vector3.zero, _visionlentgh * (Vector3.forward + Vector3.left));
        UnityEngine.Gizmos.DrawLine(Vector3.zero, _visionlentgh * (Vector3.forward + Vector3.right));

        UnityEngine.Gizmos.color = Color.blue;
        UnityEngine.Gizmos.DrawSphere(Vector3.zero, _audiolentgh);
    }
    #endregion

}
