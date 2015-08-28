








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Status : ReqlQuery {
    
    
        public Status (object arg) : this(new Arguments(arg), null) {
        }
        public Status (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Status (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.STATUS, args, optargs) {
        }

    protected Status (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Status FromArgs(params object[] args){
         return new Status (new Arguments(args), null);
        }


    

    


    
    }
}