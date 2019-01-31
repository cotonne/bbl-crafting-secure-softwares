package application;

import junitparams.*;
import org.junit.*;
import org.junit.runner.*;

@RunWith(JUnitParamsRunner.class)
public class QuantityTest {

  @Test(expected = IllegalStateException.class)
  @Parameters({"0",
          "-1"})
  public void a_negative_quantity_is_impossible(int value) {
    Quantity.of(value);
  }

  @Test(expected = IllegalStateException.class)
  public void a_quantity_should_not_be_more_than_1024() {
    Quantity.of(1024);
  }

  @Test(expected = IllegalStateException.class)
  public void a_quantity_can_overflow() {
    Quantity.of(2).multiply(Integer.MAX_VALUE);
  }
}