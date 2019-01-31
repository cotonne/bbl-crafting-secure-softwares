package application;

public class UsernameFormat {
  public static boolean validate(String name) {
    return name.matches("[a-z]{3,8}");
  }
}
