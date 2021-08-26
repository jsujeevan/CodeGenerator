using System;

namespace MassQSol_CodeGenerator_Console.templates
{
    class Model
    {
        public string Header =  "using System;\n" +
                                "using #PROJECTNAME#.BOs;\n" + 
                                "\n" +
                                "namespace #PROJECTNAME#.Models.#MODELTYPE#\n" + 
                                "{\n" +
                                "\tpublic class #MODELNAME# : GenericModel\n" + 
                                "\t{\n";

        public string Footer =  "\t}\n" + 
                                "}";

    }
}