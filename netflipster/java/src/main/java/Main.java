import repository.UserDao;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        System.out.println("Registration ---- ");
        System.out.println("Identifier:");
        String username = s.next();
        System.out.println("Password:");
        String password = s.next();

        register(username, password);

        System.out.println("Connection : ");
        System.out.println("Identifier:");
        username = s.next();
        System.out.println("Password:");
        password = s.next();

        String userId = login(username, password);
        if (userId != "") {
            System.out.println("Vous êtes connecté en tant que " + username);
            System.out.println("Films:");

            // List DVD HERE
            // Format
            // dvdId) dvdName

            System.out.println("Selection: ");
            String dvdId = s.next();
            System.out.println("Quantity: ");
            int quantity = s.nextInt();

            booking(dvdId, quantity, userId);

            System.out.println("Number of DVD : " + quantity + " , final price: 8€ x " + quantity + " DVD = " + quantity * 8 +
                    ", If you buy one more : 7€ x " + (quantity + 1) + " DVD = " + (quantity + 1) * 7 + " €");
        }

    }

    private static void register(String name, String password) {
        // Check UserDao
        UserDao.register(name, password);
    }

    private static String login(String userId, String password) {
        throw new UnsupportedOperationException();
    }

    private static void booking(String userId, int quantity, String dvdId) {
        throw new UnsupportedOperationException();
    }
}
