using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public struct MyPose
{
    //initialize a public static readonly version of this
    public static readonly MyPose empty = new MyPose { position = Vector3.zero, rotation = Quaternion.identity };

    public Vector3 position;
    public Quaternion rotation;
}

[CreateAssetMenu(menuName = "XR Hand Posing/My Create New Hand Pose")]
public class MyHandPoseScript : ScriptableObject
{
    public MyPose thumb = MyPose.empty;
    public MyPose index = MyPose.empty;
    public MyPose middle = MyPose.empty;
    public MyPose ring = MyPose.empty;
    public MyPose pinky = MyPose.empty;
}
