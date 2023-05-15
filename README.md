# **Document de design du jeu (GDD)**

### **Titre:**

Gouverne ton avenir (GTA)

### **Genre:**

Simulateur de conduite

 **Pourquoi ce simulateur?:**

Ce simulateur est de type éducatif, il visera l’apprentissage du code routier. La passation du permis de conduire est depuis de nombreuse décennie un rituel considérer comme pénible auquel toute personne souhaitant prendre le volant doit prendre part. Le but est alors de rendre ce rituel nécessaire moins pénible afin de faciliter cette passation. Nous développerons donc un simulateur afin de rendre cet apprentissage plus ludique et ce processus moins pénible en général.

### **Design du jeu:**

Le jeu sera composé de plusieurs niveau. Chaque niveau aura pour but d’apprendre au joueur une notion du code routier. Bien que ce simulateur ne soit pas un remplacement des cours de conduite, il permettra de rendre le processus plus agréable. Le joueur se verra à l’intérieur de la voiture en première vue (POV). Chaque niveau indiquera au joueur comment procéder dans les rues de manière sécuritaire en respectant le code de la route. Par exemple, le premier niveau consistera à rester dans la bonne voix sur une petite distance.

### **Graphiques et sons:**

Le jeu utilisera des graphismes en polygones de faible résolution, avec un style artistique cartoon. La ville sera remplie de divers monuments et points d'intérêt, tels que des écoles, des hôpitaux et des stations-service. Les effets sonores incluront des sons de moteur réalistes, de klaxons et de bruits ambiants de la ville.

### **Contrôle:**

Le simulateur utilise les contrôles classque des jeux su ordinateur en Amérique du Nord, donc WASD.

W: Avancé

S: Reculé
D: Aller ver la droite

A: Aller vers la gauche

Espace: freiner 

Escape: Le menu


### **Cas d’utilisation possible:**

-	Formation à la conduite.
-	Évaluation de la capacité de conduite : Les instructeurs pourront ainsi mieux guider les étudiants en identifiant leurs points faibles.
-	Tests de conduite pour les personnes âgées : Notre simulateur pourra servir de test de capacités de conduite à des personnes âgées ou n’importe quels individus en rééducation (handicapés). Ainsi, rien n’est mis à risque.
-	Particuliers rouillés
-	Conducteur provenant d’un autre pays qui veut se familiariser avec les particularités du code routier canadien.

Ainsi, nous pourrions nous affilier à une école de conduite ou tout simplement vendre notre application à des étudiants en quête de connaître leur niveau ou apprendre interactivement.


## **Technologie:**

### **Unity:**

Unity est un moteur de jeu, il est utilisé pour développer de nombreux jeux vidéo, applications et simulateurs. Celui-ci a été développé par Unity Technologies, il est disponible au grand public depuis 2005 et a accumulé une énorme communauté de programmeur qui s’entraide et partage de nombreuse ressource sur leur asset store.

### **C#:**

C’est un langage de programmation orienté objet développé par Microsoft. Il est versatile et est utilisé pour développer des application webs et mobiles ainsi que des jeux vidéo en tous genre avec Unity. Il est l’un des langages les plus utilisé et est bâtis pour être facile d’utilisation.

### **Visual Studio:**

Visual Studio est un éditeur de code utilisé par Unity de baseé Celui-ci peremt de programmer en C# et de créer des scripts afin de décire le comportement des objets en jeu. De plus. grâce aux extensions dévloppées par la communauté de cet éditeur il n'était pas nécessaire de connaître les objets de Unity parcoeur.

### **Difficulté Rencontrées:**

- Nous avous eu énormément de difficulté avec la sauvegarde du programme par Github. En effet, il est arrivé plusieurs fois de perdre des scripts ou parfois même des scènes.
- L'organisation des fichiers dans Unity était aussi une difficulté. Vu que c'était la première fois que nous utilisions Unity, nous ne savions pas en commençant comment bien organiser nos script, nos assets et nos scènes. Il est arrivé plusieurs fois lors d'importation d'assets de ne pas fairer attention et d'inutilement prendre l'entiereté de l'asset et non seulement la partie nécessaire.
- Nous avons aussi eu énormément de difficulté avec l'intelisense entre Unity et VS code qui se désactivait de manière mystérieuse. Cela nous ralentissait dans l'écriture des scripts puisque le language de Unity n'était parfois pas intégrer à VS code.

## **Perspectives ( Suite du projet si vous avez eu le double du temps et possibilités d'améliorations)**

### **GTA (gouverne ton avenir):**
- Emblir le jeu:
a) Ajouter différentes animations
b) Ajouter plus de modèle pour améliorer l'environnement et éviter les doublons
- Améliorer la physique du jeu pour la rendre plis fidàle à la réalité
- Ajouter une génération aléatoire de route et terrain pour avoir l'option de conduite libre.
- Ajouter d"autres niveaux afin de couvrir le code routier plus amplement.

### **GTA (gouvernail et titubations alternées):**
- Ceci serait une suite au premier GTA qui couvrirait le permis naval à la place de celui routier.

## **Conclusion:**

En général. nous avons vu un peu trop gros lors de l'imagination de ce projet. En effet, nous avions prévu de couvrir la totalité du code routier. ce qui consistait à faire plusieurs dizainnes de niveaux. Nous avons aussi réaliser assez rapidement que la conception d'une génération aléatoire.

En fin de compte. nous sommes arriver à créer une petite sélection de niveau comprtant des règlements importants du code routier à l'intérieur d'environnement semi-réaliste.

## **Diagramme UML:**

## **Lien du trailer:**

## **Échéancier:**

![image](https://github.com/OGPNAVYSEALS/H23-GTA/assets/123408866/97ce8d6a-3fe4-4e1d-a474-48f024da3aa8)

## **Preuve d'exécution:**

![image](https://github.com/OGPNAVYSEALS/H23-GTA/assets/123408866/488bee8c-a11b-4c3c-a62b-8ab63cedcc6a)
![image](https://github.com/OGPNAVYSEALS/H23-GTA/assets/123408866/3cd15ea7-ccd0-4f53-9748-66800b73b39a)
![image](https://github.com/OGPNAVYSEALS/H23-GTA/assets/123408866/34793834-b79e-4da4-a36d-0c2f740a9b89)

