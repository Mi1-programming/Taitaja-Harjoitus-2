using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public struct GravityGroup
{
    public string name;
    public Gravity[] gravities;
}
public class GravityController : MonoBehaviour
{
    [SerializeField] private GravityGroup[] gravityGroups;
    [SerializeField] private Dictionary<string, Gravity[]> gravityGroupsDictionary = new Dictionary<string, Gravity[]>();
    private string targetGroup;

    private void Awake()
    {
        foreach (var group in gravityGroups)
        {
            gravityGroupsDictionary.Add(group.name, group.gravities);
        }
    }
    public void RotateGlobalGravity(int addedAngle)
    {
        foreach (var gravity in Gravity.gravities)
        {
            gravity.angle += addedAngle;
        }
    }
    public void SetTargetGroup(string groupName)
    {
        targetGroup = groupName;
    }
    public void RotateLocalGravity(int addedAngle)
    {
        Gravity[] targets = gravityGroupsDictionary[targetGroup];
        foreach (var gravity in targets)
        {
            gravity.angle += addedAngle;
        }
    }
}
