import repository.UserDao;
import sun.reflect.generics.reflectiveObjects.NotImplementedException;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.println("Registration ---- ");
        System.out.println("Identifier:");
        String userId = s.next();
        System.out.println("Password:");
        String password = s.next();

        register(userId, password);

        System.out.println("Connection : ");
        System.out.println("Identifier:");
        userId = s.next();
        System.out.println("Password:");
        password = s.next();

        if (login(userId, password)) {
            System.out.println("Vous êtes connecté en tant que " + userId);
            System.out.println("Films:");

            // List DVD HERE
            // Format
            // dvdId) dvdName

            System.out.println("Selection: ");
            String dvdId = s.next();
            System.out.println("Quantity: ");
            int quantity = s.nextInt();

            booking(dvdId, quantity, userId);

            System.out.println("Nombre de DVD : " + quantity + " , prix final: 8€ x " + quantity + " DVD = " + quantity * 8 +
                    ", Si vous en prenez un de plus : 7€ x " + (quantity + 1) + " DVD = " + (quantity + 1) * 7 + " €");
        }

    }

    private static void register(String userId, String password) {
        // Check UserDao
        throw new NotImplementedException();
    }

    private static boolean login(String userId, String password) {
        throw new NotImplementedException();
    }

    private static void booking(String dvdId, int quantity, String userId) {
        throw new NotImplementedException();
    }
}
