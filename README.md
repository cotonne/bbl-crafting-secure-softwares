# NetFlipster

## Votre but

Êtes-vous prêt à devenir le nouveau NetFlix ? Oui ?
Alors, préparez-vous, la route est semée d'embûches.

## L'application

L'application est une application en mode console.
Elle est connectée à une base de données.
Seul le fichier "Main" doit être modifié.


## Use cases

À vous de jouer! En tant que PO, voici les use cases demandés :

### S'enregistrer

**En tant que** utilisateur  
**Je veux** m'enregistrer  
**Afin de** accéder à Neflipster  

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
**Afin de** commander les films sur la plate-forme  

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
1)	Harry Potter and the Philosopher's Stone 
...
```

### Commander un film

**En tant que** utilisateur  
**Je veux** commander un film  
**Afin de** pouvoir les visionner  

Exemple de sortie console de votre application
```
Selection: 
1
Quantity:
1
Votre commande de 1 VHS ( Harry Potter and the Philosopher's Stone ) sera bientôt livré
```

### Réduction sur le prix d'un film

**En tant que** utilisateur  
**Je veux** pouvoir bénéficier de réduction  
**Afin de** avoir accès à des offres intéressantes et payer moins cher

**Etant donné** la quantité de DVD sélectionnée par l'utilisateur (ex: 2 DVD)
**Quand** le prix est calculé
**Alors** le prix final tombe à 7€ par DVD s'il prend un DVD de plus

Exemple de sortie console de votre application
```
Nombre de DVD : 2, prix final: 8€ x 2 DVD = 16€, Si vous en prenez un de plus : 7€ x 3 DVD = 21€
```

