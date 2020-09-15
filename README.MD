# unity-20201-problema-al-reposicionar-plataformas-en-movimiento

En este proyecto tengo 2 plataformas que se mueven constantemente y usan un empty para colocarse una atras de la otra.

El problema surge al momento de reposicionarlas.
Para solucionarlo tuve que separar el código en 2 script.

Un script se encarga de mover la plataforma.

Otros Script se encarga de reposicionar la plataforma.


Un Tema importante es que para mover la plaforma uso FIXEDUPDATE
y para reposicionar la plataforma uso UPDATE.Si uso FIXEDUPDATE
para reposicionar la plataforma no queda en la posicion correcta.
Lo mismo ocurre si coloco todo el código en "1 script".


Me dijeron que hay un problema en la actualizacion de los fotogramas,
puede que no existe una correcta sincronización o algo que va más alla
de mi conocimiento,sin embargo en este proyecto se puede ver una forma
de solucionar este problema en Unity.Una cosa a destacar es que ocurre
el mismo problema en Godot Engine.

