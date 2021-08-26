using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassQSol_CodeGenerator_Console.templates
{
    class SP
    {

        public string SelectSp = //"DROP PROCEDURE dbo.#TABLENAME#_SELECT\n" +
                                //"GO\n" +
                                "CREATE PROCEDURE dbo.#TABLENAME#_SELECT\n" +
                                "#PARAMETERS#" +
                                "\n" +
                                "AS\n" +
                                "\n" +
                                "BEGIN\n" +
                                "\n" +
                                "SELECT\n" +
                                "#SELECT#" +
                                "FROM\n" +
                                "\tdbo.#TABLENAME#\n" +
                                "WHERE\n" +
                                "#WHERE#" +
                                "\n" +
                                "END";

        public string SelectSpCollection = //"DROP PROCEDURE dbo.#TABLENAME#_SELECT_COLLECTION\n" +
                        //"GO\n" +
                        "CREATE PROCEDURE dbo.#TABLENAME#_SELECT_COLLECTION\n" +
                        "#PARAMETERS#" +
                        "\n" +
                        "AS\n" +
                        "\n" +
                        "BEGIN\n" +
                        "\n" +
                        "SELECT\n" +
                        "#SELECT#" +
                        "FROM\n" +
                        "\tdbo.#TABLENAME#\n" +
                        "WHERE\n" +
                        "\tEXISTS" +
                        "\t(" +
                        "\tSELECT 1" +
                        "\tFROM" +
                        "\t@_PK_ PKs" +
                        "\tWHERE" +
                        "\t#TABLENAME#.#PK# = PKs._PK_" +
                        "\t)" +
                        "\n" +
                        "END";


        public string InsertSp = //"DROP PROCEDURE dbo.#TABLENAME#_INSERT\n" +
                                //"GO\n" +
                                "CREATE PROCEDURE dbo.#TABLENAME#_INSERT\n" +
                                "#PARAMETERS#" +
                                "\n" +
                                "AS\n" +
                                "\n" +
                                "BEGIN\n" +
                                "\n" +
                                "INSERT INTO dbo.#TABLENAME#\n" +
                                "\t(\n" +
                                "#COLUMNS#" +
                                "\t)\n" +
                                "VALUES\n" +
                                "\t(\n" +
                                "#VALUES#\n" +
                                "\t)\n"+
                                "\n" +
                                "END";

        public string UpdateSp = //"DROP PROCEDURE dbo.#TABLENAME#_UPDATE\n" +
                                //"GO\n" +
                                "CREATE PROCEDURE dbo.#TABLENAME#_UPDATE\n" +
                                "#PARAMETERS#" +
                                "\n" +
                                "AS\n" +
                                "\n" +
                                "BEGIN\n" +
                                "\n" +
                                "UPDATE dbo.#TABLENAME#\n" +
                                "\tSET\n" +
                                "#SET#" +
                                "\tWHERE\n" +
                                "#WHERE#\n" +
                                "\n" +
                                "END";

        public string DeleteSp = //"DROP PROCEDURE dbo.#TABLENAME#_DELETE\n" +
                                //"GO\n" +
                                "CREATE PROCEDURE dbo.#TABLENAME#_DELETE\n" +
                                "#PARAMETERS#" +
                                "\n" +
                                "AS\n" +
                                "\n" +
                                "BEGIN\n" +
                                "\n" +
                                "DELETE dbo.#TABLENAME#\n" +
                                "\tWHERE\n" +
                                "#WHERE#\n" +
                                "\n" +
                                "END";


    }
}
