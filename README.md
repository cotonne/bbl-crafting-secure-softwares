# NetFlipster

## Votre but

Êtes-vous prêt à devenir le nouveau NetFlix? Oui?
Alors, préparez-vous, la route est semée d'embûches.

## Contraintes

Seul le fichier contenant le point d'entrée de l'application
(nommé Main) peut être modifié.

## L'application

L'application est une application en mode console.
Elle est connectée à une base de données.
Seul le fichier "Main" doit être modifié.


## Use cases

A vous de jouer! En tant que PO, voici les use cases demandés:

### S'enregistrer

**En tant que** utilisateur  
**Je veux** m'enregistrer  
**Afin de** accéder à NetFlix2  

Exemple de sortie console de votre application
```
Registration ---- 
Name:
tom
Password:
pouce
```

### Se connecter

**En tant que** utilisateur  
**Je veux** me connecter  
**Afin de** commander les films sur la plateforme  

Exemple de sortie console de votre application
```
Connection ---
Name:
tom
Password:
pouce
You are connected as tom
```

### Lister les films disponibles

**En tant que** utilisateur  
**Je veux** lister les films disponibles  
**Afin de** savoir quels films sont présents  

Exemple de sortie console de votre application
```
Films:
H1)	Harry Potter and the Philosopher's Stone 
...
```

### Commander un film

**En tant que** utilisateur  
**Je veux** commander un film  
**Afin de** pouvoir les visionner  

Exemple de sortie console de votre application
```
Selection: 
H1
Quantity:
1
Your command of 1 DVD ( Harry Potter and the Philosopher's Stone ) will be sent soon
```

### Réduction sur le prix d'un film

**En tant que** utilisateur  
**Je veux** pouvoir bénéficier de réduction
**Afin de** avoir accès à des offres intéressantes et payer moins chère

**Etant donné** la quantité de DVD sélectionnée par l'utilisateur (ex: 2 DVD)
**Quand** le prix est calculé
**Alors** le prix final tombe à 7€ par DVD s'il prend un DVD de plus

Exemple de sortie console de votre application
```
Nombre de DVD : 2, prix final: 8€ x 2 DVD = 16€, Si vous en prenez un de plus : 7€ x 3 DVD = 21€
```




