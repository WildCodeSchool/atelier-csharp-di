# Injection de dépendance

L'application ici présente permet actuellement d'afficher la liste des étudiants de l'école de Toulouse.

Bordeaux aimerait avoir la même application, affichant la liste de ses élèves.

Il te faut donc adapter le code afin de changer l'affichage de la liste d'élèves, en fonction de l'école.

## 1 - État actuel : couplage fort

En regardant le code actuel du projet, tu peux voir que la liste des élèves est "en dur" dans la classe `StudentController`.

> Quand une classe crée les instances d'une autre classe, on appelle cela un couplage fort.

Afin d'afficher une autre liste, il te faudrait créer des méthodes différentes et appeler ces dernières selon l'école. Le code devriendra de plus en plus difficile à maintenir, au fur et à mesure d'ajouts ou des modifications futures.

## 2 - Passage à l'injection de dépendance : couplage faible

Afin d'améliorer le code existant et retirer le couplage fort, tu va mettre en place un **DAO**, ainsi qu'une **injection de dépendance** :

* Crée une nouvelle interface `StudentDao`, qui possède la signature de la méthode `FindAllTls()`, retournant une `List<Student>`.
* Crée une classe `StudentRepo`, implémentant `StudentDao`. L'implémentation retourne la liste des étudiants Toulousains (celle qui est actuellement dans `StudentController`).
* Modifie `StudentController` afin de récupérer la liste d'étudiants à partir de `StudentRepo`, par injection de dépendance.

> Tu n'auras pas à créer de base de données dans cet atelier

## 3 - Plusieurs méthodes

* Ajoute une deuxième méthode `FindAllBdx` dans `StudentDao` et implémente là dans `StudentRepo`. Cette méthode retourne une liste d'étudiants Bordelais (de ton choix).
* Modifie `StudentController`, afin de pouvoir charger la liste d'étudiant grâce à la route `/students_bdx`.