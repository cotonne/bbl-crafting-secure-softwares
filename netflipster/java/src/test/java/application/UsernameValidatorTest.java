package application;

import org.junit.*;

import static org.junit.Assert.*;

public class UsernameValidatorTest {

  @Test
  public void a_valid_name_is_made_of_letters_only() {
    String username = "tom";
    boolean isValid = UsernameValidator.validate(username);
    assertTrue(isValid);
  }

  @Test
  public void it_is_invalid_otherwise() {
    String username = "Tom";
    boolean isValid = UsernameValidator.validate(username);
    assertFalse(isValid);
  }

  @Test
  public void control_character_should_not_be_accepted() {
    String username = "tom\u001B[41m";
    boolean isValid = UsernameValidator.validate(username);
    assertFalse(isValid);
  }
}