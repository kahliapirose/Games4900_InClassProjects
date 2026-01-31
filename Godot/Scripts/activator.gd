extends Node3D

class_name ActivatorClass

@export var HelloComponent: Greeter
# Start
# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	if HelloComponent == null:
		push_warning("NO Gretter assigned to UsesGreeter.gd")
		return
		
	print(HelloComponent.SayHello())
	pass
