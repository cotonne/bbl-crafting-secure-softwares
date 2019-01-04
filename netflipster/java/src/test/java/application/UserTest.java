package application;

import org.junit.*;

import java.io.*;
import java.nio.charset.*;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.Assert.assertEquals;

public class UserTest {

    @Test
    public void be_able_to_register() throws UnsupportedEncodingException {
        final ByteArrayOutputStream baos = defineScenario("john\npassword\njack\npassword\n");

        Main.main(null);

        String output = new String(baos.toByteArray(), StandardCharsets.UTF_8);
        assertEquals(output, "Registration ---- \nIdentifier:\nPassword:\nConnection : \nIdentifier:\nPassword:\n" +
                "Fail to log as jack\n");
    }

    @Test
    public void be_able_to_connect() throws UnsupportedEncodingException {
        ByteArrayOutputStream baos = defineScenario("john\npassword\njohn\npassword\n1\n1\n");

        Main.main(null);
        String data = new String(baos.toByteArray(), StandardCharsets.UTF_8);
        assertThat(data).isEqualToIgnoringNewLines(
                "Registration ---- \nIdentifier:\nPassword:\nConnection : \nIdentifier:\nPassword:\n" +
                        "Vous êtes connecté en tant que john\n" +
                        "Films:\n" +
                        "1) Harry Potter and the Philosophers Stone (2001)\n" +
                        "2) Harry Potter and the Chamber of Secrets (2002)\n" +
                        "3) Harry Potter and the Prisoner of Azkaban (2004)\n" +
                        "4) Harry Potter and the Goblet of Fire (2005)\n" +
                        "5) Harry Potter and the Order of the Phoenix (2007)\n" +
                        "6) Harry Potter and the Half-Blood Prince (2009)\n" +
                        "7) Harry Potter and the Deathly Hallows – Part 1 (2010)\n" +
                        "8) Harry Potter and the Deathly Hallows – Part 2 (2011)\n" +
                        "Selection: \n" +
                        "Harry Potter is an orphaned boy brought up by his unkind Muggle (non-magical) aunt and uncle.\n" +
                        "At the age of eleven, half-giant Rubeus Hagrid informs him that he is actually a wizard\n" +
                        "Quantity: \n" +
                        "Number of VHS : 1 , final price: 8€ x 1 VHS = 8, If you buy one more : 7€ x 2 VHS = 14 €\n");
    }

    private ByteArrayOutputStream defineScenario(String initialString) throws UnsupportedEncodingException {
        final ByteArrayOutputStream baos = new ByteArrayOutputStream();
        PrintStream out = new PrintStream(baos, true, "UTF-8");
        System.setOut(out);
        System.setErr(out);

        InputStream in = new ByteArrayInputStream(initialString.getBytes());
        System.setIn(in);
        return baos;
    }
}
