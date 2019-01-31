package application;

import java.util.*;

public class Quantity {
  final int value;

  private Quantity(int value) {
    this.value = value;
  }

  static Quantity of(int value) {
    if (value <= 0)
      throw new IllegalStateException("A quantity can't be negative");
    if (value >= 1024)
      throw new IllegalStateException("A quantity can't be more than 1024");
    return new Quantity(value);
  }

  Quantity add(Quantity other) {
    return Quantity.of(value + other.value);
  }

  Quantity multiply(int scalar) {
    return Quantity.of(value * scalar);
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) return true;
    if (o == null || getClass() != o.getClass()) return false;
    Quantity quantity = (Quantity) o;
    return value == quantity.value;
  }

  @Override
  public int hashCode() {
    return Objects.hash(value);
  }

  @Override
  public String toString() {
    return "" + value;
  }
}
