using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IManagable
{
    void FirstInitialize();
    void SecondInitialize();
    void Refresh();
    void PhysicsRefresh();
}
