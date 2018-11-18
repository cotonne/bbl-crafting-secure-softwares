package application;

import repository.*;

import java.util.*;

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

            Collection<String> identifiers = VhsDao.getIdentifiers();
            for (String id : identifiers) {
                String name = VhsDao.getVhsNameById(id);
                System.out.println(id + ") " + name);
            }

            System.out.println("Selection: ");
            String id = s.next();
            System.out.println(readDescription(id));
            System.out.println("Quantity: ");
            int qty = s.nextInt();

            booking(id, qty, userId);

            System.out.println("Number of VHS : " + qty + " , final price: 8€ x " + qty + " VHS = " + qty * 8 +
                    ", If you buy one more : 7€ x " + (qty + 1) + " VHS = " + (qty + 1) * 7 + " €");
        } else {
            System.err.println("Fail to log as " + username);
        }

    }

    private static String readDescription(String id) {
        return FileDao.read(id);
    }

    private static void register(String name, String password) {
        UserDao.register(name, password);
    }

    private static String login(String name, String password) {
        return UserDao.findId(name, password);
    }

    private static void booking(String userId, int quantity, String vhsId) {
        BookingDao.book(userId, quantity, vhsId);
    }
}
