﻿/**
 * 抽象工厂模式：提供一个创建一系列相关或相互依赖对象的接口，而无需置顶它们具体的类。
 * 优缺点：
 * 1. 便于交换产品系列，由于具体的工厂类在一个应用中只需要在初始化的时候出现一次，这就使得改变一个应用的具体工厂变得非常容易，它只需要改变具体工厂即可使用不同的产品配置；
 * 2. 让具体的创建实例的过程与客户端分离，客户端是通过它们的抽象接口操纵实例，产品的具体类名也被具体工厂的实现分裂。
 * 
 */
using System;

namespace AbstractFacotry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
