package repository;

import source.DB;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Collection;

public class VhsDao {

    /**
     * Get the list of VHSs identifiers
     *
     * @return list of VHS identifiers
     */
    public static Collection<String> getIdentifiers() {
        Collection<String> vhs = new ArrayList<>();
        ResultSet rs = DB.execute("SELECT ID FROM VHS WHERE ID > 0");
        try {
            while (rs.next()) {
                int id = rs.getInt("ID");
                vhs.add(String.valueOf(id));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return vhs;
    }

    /**
     * Get the name of the VHS
     *
     * @param id identifier of the VHS
     * @return list of VHS names
     */
    public static String getVhsNameById(String id) {
        ResultSet rs = DB.execute(String.format("SELECT NAME FROM VHS WHERE ID = %s", id));
        try {
            rs.next();
            return rs.getString("NAME");
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }
}
