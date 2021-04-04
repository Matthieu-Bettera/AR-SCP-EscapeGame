# AR-SCP-EscapeGame

## Repartition des taches (code):

	Pierre Jeanne       : Menu principal (transition entre les scenes, timer, pénalité, code et machine )
	Jonathan Desjardins : Menu principal (Bouton revoir indice et indice ) 
	Louis Juste         : Machine de l'interrogatoire et du tuyau 
	Pierre Tahon        : Machine conversation téléphonique avec Malo
	Matthieu Delannoy   : Machine AR


## Problèmes rencontrés :

				 1: l'AR
	 
	L'objectif était de créer une télé composée de 5 écrans (4 autour et un au dessus) ou la statue apparaissait.
	Ces écrans ne s'allumait que si le joueur était présent devant. 
	Le but était de garder en vision la statue alors qu'une jauge augmentait si on ne la regardait pas, cette dite jauge descendait quand la statue était en visuel.
	Malheureusement même si tout cela était fonctionnel l'objectif était que le joueur puisse tourner autour de la statue mais l'application en AR s'est révélé impossible, 
	la télé ne voulant pas apparaître quand demandé et même si elle apparaissait la rotation autour de celle-ci était impossible.
				
				2: Faire un traducteur fonctionnel
				
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
