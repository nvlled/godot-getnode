using Godot;
using System;
using godot_getnode;

public partial class Example : Control
{
    [GetNode("Container/CenterContainer/VBoxContainer/Label")] Label _label;
    [GetNode("%Name")] LineEdit _name;
    [GetNode(Unique: true)] Button Submit;
    [GetNode("Container/Greeting")] public Label Greeting;

    string greet = "Hello";

    public override void _Ready()
    {
        // GetAnnotatedNodes() must be called
        // before using the nodes.
        this.GetAnnotatedNodes();
        // or GetNodeAttribute.Ready(this);

        _label.Text = "Name:";
        _name.PlaceholderText = "Your name";

        Submit.Pressed += OnSubmit;
        Submit.Text = "Submit";

        GD.PrintT(_label, _name, Submit);
    }

    private void OnSubmit()
    {
        Greeting.Text = $"{greet} {_name.Text}, how are you";
    }
}
