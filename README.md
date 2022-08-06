# Unity Input Control

- Import the `Input System` from `Asset Manager`
- Create Input Action and tick the `Generate C#`
    - Movement should be `Value` and `Vector2`
    - Jump should be `Button`
- PlayerController
    - Enable the Input Action
    - Add a lambda expression to `performed` callback for jumping
    - Use `ReadValue` to set the movement direction
    - Rotate to where the player wants to moved using `Quaternion`
    - Jump
- CameraController
    - Follow the selected transform
