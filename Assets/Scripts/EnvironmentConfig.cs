using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentConfig : MonoBehaviour
{
    [SerializeField] EnvironmentType _EnvironmentType;
    [SerializeField] List<Environment> _Environments;

    private static EnvironmentConfig _SINGLETON;

    private void Awake()
    {
        _SINGLETON = this;
    }

    static public Environment GetEnvironment()
    {
        return _SINGLETON.GetEnvironmentInner();
    }

    private Environment GetEnvironmentInner()
    {
        switch (_EnvironmentType)
        {
            case EnvironmentType.DEVELOP:
                return _Environments[0];
            case EnvironmentType.PRODUCT:
                return _Environments[1];
        }
        throw new System.ArgumentException("参照不能");
    }
}

