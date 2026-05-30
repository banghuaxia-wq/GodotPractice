using Godot;
/// <summary>
/// 本状态用于响应输入处理器(Inputhandler)发送来的输入事件，在没有接收到输入事件时，本状态会持续监听并阻断状态循环
/// </summary>
public partial class WaitForInputState : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
