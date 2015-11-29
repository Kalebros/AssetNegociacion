# AssetNegociacion
Asset de negociacion para Granada Gaming Jaming

# Lista de assets añadidos

- Character

# Uso del asset para dialogo:
El asset se compone de dos Scripts principales, NegotiationPlayer y NegotiationActivator.

NegotiationPlayer debe de colocarse en el RigidBodyFPSController, y asociarse con los diferentes
"paneles de conversacion" (ver más adelante); hay que modificar el NegotiationPlayer para
que pueda asociarse con todos los paneles de converacion y desactivarlos todos en el Start()

Hay que añadir un Canvas a la jerarquía de la escena y dentro del canvas, ir
añadiendo paneles; cada panel equivale a un estado de la conversacion.

Cada estado de la conversación incluye, idealmente, un texto con la entrada del
narrador, y diferentes botones para poder escoger opciones que te llevarán a diferentes estados.

Tenemos que añadir un GameObject vacio a la jerarquía (p.e, LOGIC), donde colocaremos el
NegotiationActivator. Debemos de modificar el script para poder asociar todos los estados
de conversacion.

Cada transición de estado debe de ser una función public void que se llame to<Proximo estado>(),
la cual debe de desactivar todos los estados que no se utilizan y dejar sólamente activo el estado
correcto.

Asociar cada botón a cada una de las transiciones de estado de LOGIC. Y eso debería de bastar.
