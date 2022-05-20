using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class WaitTime : MonoBehaviour
{
    // ================ async ================
    //private void Start()
    //{
    //    Task.Run(Wait);
    //}

    //// async: �񵿱�� �۵��ϴ� �ż���
    //async void Wait()
    //{
    //    print("Hi, ");
    //    await Task.Delay(1000);
    //    print("Seoul!");
    //}

    // ================ thread ================
    private void Start()
    {
        Thread thread = new Thread(Run);
        thread.Start();
    }

    private void Run()
    {
        print("Hi, ");
        Thread.Sleep(1000);
        print("Seoul!");
    }
}
