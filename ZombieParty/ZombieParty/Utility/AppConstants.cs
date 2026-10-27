namespace ZombieParty.Utility
{
    public class AppConstants
    {
        // Gestion des notifications Toastr
        public const string Success = "Success";
        public const string Error = "Error";

        // Chemins d'accès pour les fichiers/images à partir du ROOT ~
        public static string ImagePath = @"images/";
        public static string ImagePathZombies = ImagePath + @"zombies/";
        public static string ImagePathZombiesCtrl = @"images/zombies/"; // Utilisé dans les contrôleurs
        public static string ImageGeneric = @"GenericZombie.png";
    }
}
