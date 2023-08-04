# Bridge Pattern
Bridge is usually designed up-front, letting you develop parts of an application independently of each other.
On the other hand, Adapter is commonly used with an existing app to make some otherwise-incompatible classes work together nicely.
Useful when you prefer composition over inheritance.
```
                   ----Shape---
                  /            \
         Rectangle              Circle
        /         \            /      \
BlueRectangle  RedRectangle BlueCircle RedCircle
```
vs
```
          ----Shape---                        Color
         /            \                       /   \
Rectangle(Color)   Circle(Color)           Blue   Red
```

In Bridge, client deals with abstraction, and the components deal with the defined interface
In Adapter, client deals with the defined interface, and the components are probably exisitng code that doesn't adhere to any interface
