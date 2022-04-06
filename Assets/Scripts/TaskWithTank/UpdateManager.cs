using System;
using UnityEngine;


public interface ITickable
{
    void Tik();
}

public class UpdateManager : MonoBehaviour
{
    public ITickable[] tickables;
    private static int nextTickables;

    private void Awake()
    {
        tickables = new ITickable[100];
        nextTickables = 0;
    }

    

    void Update()
    {
        foreach (var obj in tickables)
        {
            if (obj != null)
                obj.Tik();
        }
    }

    public void AddTank(ITickable iTickable)
    {
        tickables[nextTickables] = iTickable;
        nextTickables++;
    }

    public void RemoveTank(ITickable iTickable)
    {
        for (int i = 0; i < tickables.Length; i++)
        {
            if (tickables[i] == iTickable)
            {
                tickables[i] = null;
            }
        }
        
    }
}