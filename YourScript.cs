GameObject parent = new GameObject("Parent");
Undo.RegisterCreatedObjectUndo(parent, "Create Parent");

GameObject child = new GameObject("Child");
Undo.RegisterCreatedObjectUndo(child, "Create Child");
child.transform.SetParent(parent.transform); 