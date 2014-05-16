Gestion d'une école (Asp.Net)
Gestion d'une Ecole

Ce projet gère plusieurs volets:

    -Gestion des inscriptions des Étudiants 
    -Gestion de la présence des Étudiants 
    -Gestion de la notation des Étudiants 
    -Gestion de la distribution des cours aux Enseignants
    -Gestion des matières Gestion des niveaux d’utilisateurs

Au niveau Serveur :

  Plateforme Cibles

        Windows Server + IIS ou Windows Azure

  Environnement d’exécution

        .Net 4.5 
        
        SQL Server Express

  Environnement de développement

         ASP.NET MVC 4
         
         Entity FrameWork
          
Au niveau Client

        HTML5 – CSS3
      
        Bootstrap 3
      
        Modernizr
      
        JQuery
        
Au niveau Sécurité:

Sécurité d’authentification

        Login et Mot de passe encrypté (RSA)
      
        Identification formulaire de Windows
        
        Sécurité des formulaires

        
Au niveau Optimisation:

        Regroupement des flux (Bundles)
     
        Mise en place du Caching
      
Réalisation :

        Les besoins  de l’applications ont été satisfaits. L’application est désormais fonctionnelle sur le site.
        
        Mise en place de la sécurité a été gérée sur tous les niveaux.
    
Développements à-venir:

        Gestion de paiement des frais d’admission.
     
        Forum de discussion entre professeurs, étudiants et administration.
  

Directives d'utilisation:

    1-  L'application est disponible en français et en anglais : veuillez choisir une langue. 
    
    2-  Il faut créér un client: renter un email + un mot de passe valide : (se souvenir du mot de passe) Ce client peut voir seulement notre page home. On a limité l'accés pour des raisons de sécurité.
    
    3-  Il faut se déconnecter maintenant et rentrer en tant que Administrateur Username: Admin - mot de passe :abc123...
    
    4-  Une fois admin il peut aller sur sa section administration: En tant que Admin changer le statut du client à un etudiant.
    
        J'ai séparé la base donnée de sécurité de la base de donnée de mon application pour des fins de sécurité.
        
    5-  Toujours en tant que admin : Il faut maintenant aller dans la rubrique Etudiant, enregistrer ce client là pour devenir un étudiant avec son mail. Le client est devenu un Étudiant maintenant.
    
    6-  Toujours en tant que admin : Créér maintenant des matieres au moins deux matieres (exemple php, c++)...et valider votre choix 
    
    7-  Toujours en tant que admin : Créér des types d'évaluations exemple (Quiz1 , Quiz final).
    
    8-  Une fois que ces données sont rentrées il ne reste plus qu'à rajouter un professeur et rajouter aussi des cours enseignée par ces proffesseurs là.
    
        Pour ce faire, faire refaire l'étape 2 - 3 - 4 et 5 mais pour enseignant au lieu d'un étudiant.
        
    9-  Associer des cours à l'enseignant dans la rubrique cours. 
    
    10- Se déconnecter d'admin puis on se connecte en tant que Etudiant. L'etudiant peut rentrer dans la rubrique des étudiants, il ne peut rentrer que sur son profile, il regarde alors ses données: cours, matiere, notes si c'est disponible.
    
        NB: Un cours c'est une saison exemple saison d'hiver. On peut avoir plusieurs cours dans une matiere.
        
        L'étudiant s'inscrit à un cours . Il s'ajoute automatiquement à sa liste de cours.
        
        L'étudiant peut consulter les matières offert, et les détails des matieres, dans la rubrique des matieres.
        
    11- Se déconnecter d'étudiant. Se connecter en tant que enseignant. L'enseignant rentre sur sa rubrique d'enseignant, il ne peut acceder qu'à son profil.
        
        L'enseignant peut consulter ses cours et dans chaque cours il peut voir sa liste d'étudiants. Il peut alors soit marquer la présence au cours pour chaque étudiant, soit le noter.
        
    12- Une fois noté par l'enseignant on se déconnecte de l'enseignant. 
        
        On se reconnecte avec l'étudiant afin de vérifier si il a reçu ses notes.
       
        Eh oui ! il est noté il peut voir sa moyenne, lorsqu'il rentre sur son profil, et même les détails de ses notes.
    
        Eh voilà j'éspère que ça été bien exliqué!
