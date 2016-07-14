














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

    public partial class Keys : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return an array containing all of an object's keys. Note that the keys will be sorted as described in <a href="/docs/data-types/#sorting-order">ReQL data types</a> (for strings, lexicographically).</para>
/// </summary>
/// <example><para>Example: Get all the keys from a table row.</para>
/// <code>// row: { id: 1, mail: "fred@example.com", name: "fred" }
/// 
/// r.table('users').get(1).keys().run(conn, callback);
/// // Result passed to callback
/// [ "id", "mail", "name" ]
/// </code></example>
        public Keys (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return an array containing all of an object's keys. Note that the keys will be sorted as described in <a href="/docs/data-types/#sorting-order">ReQL data types</a> (for strings, lexicographically).</para>
/// </summary>
/// <example><para>Example: Get all the keys from a table row.</para>
/// <code>// row: { id: 1, mail: "fred@example.com", name: "fred" }
/// 
/// r.table('users').get(1).keys().run(conn, callback);
/// // Result passed to callback
/// [ "id", "mail", "name" ]
/// </code></example>
        public Keys (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return an array containing all of an object's keys. Note that the keys will be sorted as described in <a href="/docs/data-types/#sorting-order">ReQL data types</a> (for strings, lexicographically).</para>
/// </summary>
/// <example><para>Example: Get all the keys from a table row.</para>
/// <code>// row: { id: 1, mail: "fred@example.com", name: "fred" }
/// 
/// r.table('users').get(1).keys().run(conn, callback);
/// // Result passed to callback
/// [ "id", "mail", "name" ]
/// </code></example>
        public Keys (Arguments args, OptArgs optargs)
         : base(TermType.KEYS, args, optargs) {
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
