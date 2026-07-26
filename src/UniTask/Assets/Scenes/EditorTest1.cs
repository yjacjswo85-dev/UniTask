#if UNITY_EDITOR

using System;
using Cysharp.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public class Test1
{
    [MenuItem("Test/Test1")]
    public static async UniTaskVoid TestFunc()
    {
        await DoSomeThing();
    }

    public static async UniTask DoSomeThing()
    {
        Debug.Log("Dosomething");
        await UniTask.Delay(1500, DelayType.DeltaTime);
        Debug.Log("Dosomething 2");
        await UniTask.Delay(1000, DelayType.DeltaTime);
        Debug.Log("Dosomething 3");
        Debug.Log("and Quit.");

        Environment.Exit(0);
    }
}

#endif