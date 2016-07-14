














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

    public partial class Grant : ReqlExpr {

    
    
    
/// <summary>
/// <para>Grant or deny access permissions for a user account, globally or on a per-database or per-table basis.</para>
/// </summary>
/// <example><para>Example: Grant the <code>chatapp</code> user account read and write permissions on the <code>users</code> database.</para>
/// <code>r.db('users').grant('chatapp', {read: true, write: true}).run(conn, callback);
/// 
/// // Result passed to callback
/// {
///     "granted": 1,
///     "permissions_changes": [
///         {
///             "new_val": { "read": true, "write": true },
///             "old_val": { null }
///         }
///     ]
/// </code></example>
        public Grant (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Grant or deny access permissions for a user account, globally or on a per-database or per-table basis.</para>
/// </summary>
/// <example><para>Example: Grant the <code>chatapp</code> user account read and write permissions on the <code>users</code> database.</para>
/// <code>r.db('users').grant('chatapp', {read: true, write: true}).run(conn, callback);
/// 
/// // Result passed to callback
/// {
///     "granted": 1,
///     "permissions_changes": [
///         {
///             "new_val": { "read": true, "write": true },
///             "old_val": { null }
///         }
///     ]
/// </code></example>
        public Grant (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Grant or deny access permissions for a user account, globally or on a per-database or per-table basis.</para>
/// </summary>
/// <example><para>Example: Grant the <code>chatapp</code> user account read and write permissions on the <code>users</code> database.</para>
/// <code>r.db('users').grant('chatapp', {read: true, write: true}).run(conn, callback);
/// 
/// // Result passed to callback
/// {
///     "granted": 1,
///     "permissions_changes": [
///         {
///             "new_val": { "read": true, "write": true },
///             "old_val": { null }
///         }
///     ]
/// </code></example>
        public Grant (Arguments args, OptArgs optargs)
         : base(TermType.GRANT, args, optargs) {
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
