# AR-SCP-EscapeGame

## Repartition des taches (code):

	Pierre Jeanne       : Menu principal (transition entre les scenes, timer, pénalité, code et machine )
	Jonathan Desjardins : Menu principal (Bouton revoir indice et indice ) 
	Louis Juste         : Machine de l'interrogatoire et du tuyau 
	Pierre Tahon        : Machine conversation téléphonique avec Malo
	Matthieu Delannoy   : Machine AR


## Problèmes rencontrés :

				
				1: Faire un traducteur fonctionnel
				
	L'objectif etait de faire un traducteur qui traduirait le français en langage par odre alphabetique inversé et d'utiliser ce traducteur afin de créer une conversation
	entre le joueur et Malo .
	Cependant je me suis fixé pour objectif de faire quelque chose de fonctionnel et qui soit capable de traduire n'importe quel phrase , en le moins de ligne de code 	 
	possible afin qu'il soit modifiable par n'importe qui.

## Problèmes résolus : 

				Le traducteur :
	
	Le problème du traducteur a été résolu en 3 scripts dont 1 d'une cinquantaine de lignes , un autre d'une ligne et un manager d'une centaine de lignes (un manager , un 
	scriptable object , un traducteur ) : 
	Le traducteur est attaché au prefab de la discussion de Malo , il est chargé d'ecouter le manager et de traduire ce que dit le manager .
	Le manager quand à lui est chargé d'analyser ce que dit le joueur et de changer de reponse en fonction de ce qu'a repondu le joueur et des scriptable objects.
	Pour finir le scriptable object est composé d'un simple string modifiable obligatoirement écrit en majuscule sans espaces qui constitue la reponse à traduire.

## Ce que chacun pense du cours de code :

	Pierre Tahon :
Le cour de code etait très interessant , je trouvais la methode de nous faire travailler directement sur de la pratique plutot que sur du theorique plutot efficace .
Après il y a bel et bien un point negatif à cette methode c'est que ça nous force parfois à bacler certains projets , car on n'as pas le temps de s'occuper du projet en cour et d'un autre projet dans une autre matiere . 
Néanmoins faire le runner et le rogue-like etait plutot amusant , ça aurait ete dommage de ne pas avoir à les faire .
