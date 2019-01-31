package application;

public class Sql {
  public static String escapeQuote(String sqlString) {
    return sqlString.replace("'", "");
  }
}
