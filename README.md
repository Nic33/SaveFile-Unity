# Sauvegarde des données sur Unity

Pour mon jeu vidéo [Leaky Wheel](https://play.google.com/store/apps/details?id=com.Sevenic.LeakyWheelAndroid&hl=en&gl=FR) disponible sur Android, j'utilise un fichier text pour sauvegarder les données du joueur.

L'objectif est de sauvegarder les données en local et pas sur un serveur. Cela permet à l'utilisateur de pouvoir jouer hors connexion.

Il y a 3 fichiers disponibles, car l'emplacement du fichier text de sauvegarde change en fonction des supports. Pour l'instant seulement les données lignes par lignes peuvent être lue. Dans une MàJ future, j'inclurai une fonctionnalité pour lire et écrire à un endroit précis et ainsi gagner du temps pour la sauvegarde.

Version d'Unity : 2021.3.7f1