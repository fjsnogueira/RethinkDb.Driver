














//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Uuid : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return a UUID (universally unique identifier), a string that can be used as a unique ID. If a string is passed to <code>uuid</code> as an argument, the UUID will be deterministic, derived from the string's SHA-1 hash.</para>
/// </summary>
/// <example><para>Example: Generate a UUID.</para>
/// <code>&gt; r.uuid().run(conn, callback)
/// // result returned to callback
/// "27961a0e-f4e8-4eb3-bf95-c5203e1d87b9"
/// </code></example>
        public Uuid (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return a UUID (universally unique identifier), a string that can be used as a unique ID. If a string is passed to <code>uuid</code> as an argument, the UUID will be deterministic, derived from the string's SHA-1 hash.</para>
/// </summary>
/// <example><para>Example: Generate a UUID.</para>
/// <code>&gt; r.uuid().run(conn, callback)
/// // result returned to callback
/// "27961a0e-f4e8-4eb3-bf95-c5203e1d87b9"
/// </code></example>
        public Uuid (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return a UUID (universally unique identifier), a string that can be used as a unique ID. If a string is passed to <code>uuid</code> as an argument, the UUID will be deterministic, derived from the string's SHA-1 hash.</para>
/// </summary>
/// <example><para>Example: Generate a UUID.</para>
/// <code>&gt; r.uuid().run(conn, callback)
/// // result returned to callback
/// "27961a0e-f4e8-4eb3-bf95-c5203e1d87b9"
/// </code></example>
        public Uuid (Arguments args, OptArgs optargs)
         : base(TermType.UUID, args, optargs) {
        }


    



    


    

    
        /// <summary>
        /// Get a single field from an object. If called on a sequence, gets that field from every object in the sequence, skipping objects that lack it.
        /// </summary>
        /// <param name="bracket"></param>
        public new Bracket this[string bracket] => base[bracket];
        
        /// <summary>
        /// Get the nth element of a sequence, counting from zero. If the argument is negative, count from the last element.
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        public new Bracket this[int bracket] => base[bracket];


    

    


    
    }
}
