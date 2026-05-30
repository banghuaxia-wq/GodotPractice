using Godot;
using System;

/// <summary>
/// 状态循环启动的时候首先进入的状态,并在本状态中初始化状态机和状态模块外的所有entity和manager，在切换到其他主场景前不会再次进入这个本状态。
/// </summary>
public partial class StartState : Node
{
	public void Initialize()
	{
		GD.Print("初始化Entity和Manager");
	}
}
