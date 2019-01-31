package application;

import junitparams.*;
import org.junit.*;
import org.junit.runner.*;

import static org.junit.Assert.*;

@RunWith(JUnitParamsRunner.class)
public class UsernameFormatTest {

  @Test
  @Parameters({
          "square",
          "sponge",
          "bob"
  })
  public void a_valid_name_is_made_of_letters_only(String username) {
    boolean isValid = UsernameFormat.validate(username);
    assertTrue(isValid);
  }

  @Test
  @Parameters({
          "Tom",
          "AA",
          "ExtraLong"
  })
  public void it_is_invalid_otherwise(String username) {
    boolean isValid = UsernameFormat.validate(username);
    assertFalse(isValid);
  }

  @Test
  public void control_character_should_not_be_accepted() {
    String username = "tom\u001B[41m";
    boolean isValid = UsernameFormat.validate(username);
    assertFalse(isValid);
  }
}