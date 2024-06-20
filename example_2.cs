using Godot;
using godot_getnode;
using System;

public partial class example_2 : Control
{
    [GetNode] Label Label;

    public override void _Ready()
    {
        this.GetAnnotatedNodes();
        Label.Text = "Example 2:";
    }
}
