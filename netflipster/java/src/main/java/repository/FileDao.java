package repository;

import java.io.*;
import java.nio.file.*;

public class FileDao {
    public static String read(String id) {
        try {
            Path path = Paths.get("movies/" + id);
            return new String(Files.readAllBytes(path));
        } catch (IOException e) {
            return "No description available";
        }
    }
}
