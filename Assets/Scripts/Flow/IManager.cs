using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IManager
{
    void FirstInitialize();
    void SecondInitialize();
    void Refresh();
    void PhysicsRefresh();
}
