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

            // List VHS HERE
            // Format
            // vhsId) vhsName

            System.out.println("Selection: ");
            String vhsId = s.next();
            System.out.println("Quantity: ");
            int quantity = s.nextInt();

            booking(vhsId, quantity, userId);

            System.out.println("Number of VHS : " + quantity + " , final price: 8€ x " + quantity + " VHS = " + quantity * 8 +
                    ", If you buy one more : 7€ x " + (quantity + 1) + " VHS = " + (quantity + 1) * 7 + " €");
        }

    }

    private static void register(String name, String password) {
        // Check UserDao
        throw new UnsupportedOperationException();
    }

    private static String login(String name, String password) {
        throw new UnsupportedOperationException();
    }

    private static void booking(String userId, int quantity, String vhsId) {
        throw new UnsupportedOperationException();
    }
}
