# getnode

A minimal C# library to reduce boilerplate code when
getting nodes in Godot 4 (and maybe Godot 3).

Before:

```c#
     public Label _label;
     public LineEdit _name;
     public Button Submit;
     public Label Greeting;

    public override void _Ready()
    {
        _label = GetNode<Label>("CenterContainer/VBoxContainer/Label");
        _name = GetNode<LineEdit>("%Name");
        Submit = GetNode<Button>("%Submit");
        Greeting = GetNode<Label>("%Greeting");
    }
```

After using the library:

```c#
    [GetNode("CenterContainer/VBoxContainer/Label")] public Label _label;
    [GetNode("%Name")] public LineEdit _name;
    [GetNode(Unique: true)] public Button Submit;
    [GetNode] public Label Greeting;

    public override void _Ready()
    {
        GetNodeAttribute.Ready(this);
        // or this.GetAnnotatedNodes();
    }
```

## Installation

Just copy GetNode.cs and drop it in any godot project.
Then add `using godot_getnode;` at the top of the C# script file.
See Example.cs for complete usage details.

## Alternatives

- https://github.com/FlooferLand/GodotGetNode
- https://github.com/31/GodotOnReady (Godot 3 only)

Both of thoses projects also are complex, and uses code generation magic to simulate
the @onready behaviour of gdscript. This library has way less features,
but covers about 80% (my) use cases, I think. It works with inherited nodes too.

See also https://github.com/godotengine/godot-proposals/issues/2425 for the motivations
why these projects exist.
