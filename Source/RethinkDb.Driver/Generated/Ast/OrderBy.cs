














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

    public partial class OrderBy : ReqlExpr {

    
    
    
/// <summary>
/// <para>Sort the sequence by document values of the given key(s). To specify
/// the ordering, wrap the attribute with either <code>r.asc</code> or <code>r.desc</code>
/// (defaults to ascending).</para>
/// </summary>
/// <example><para>Example: Order all the posts using the index <code>date</code>.</para>
/// <code>r.table('posts').orderBy({index: 'date'}).run(conn, callback);
/// </code></example>
        public OrderBy (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Sort the sequence by document values of the given key(s). To specify
/// the ordering, wrap the attribute with either <code>r.asc</code> or <code>r.desc</code>
/// (defaults to ascending).</para>
/// </summary>
/// <example><para>Example: Order all the posts using the index <code>date</code>.</para>
/// <code>r.table('posts').orderBy({index: 'date'}).run(conn, callback);
/// </code></example>
        public OrderBy (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Sort the sequence by document values of the given key(s). To specify
/// the ordering, wrap the attribute with either <code>r.asc</code> or <code>r.desc</code>
/// (defaults to ascending).</para>
/// </summary>
/// <example><para>Example: Order all the posts using the index <code>date</code>.</para>
/// <code>r.table('posts').orderBy({index: 'date'}).run(conn, callback);
/// </code></example>
        public OrderBy (Arguments args, OptArgs optargs)
         : base(TermType.ORDER_BY, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_EXPR"
///</summary>
        public OrderBy this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new OrderBy (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "index": "T_EXPR"
///</summary>
    public OrderBy this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new OrderBy (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "index": "T_EXPR"
///</summary>
        public OrderBy OptArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new OrderBy (this.Args, newOptArgs);
        }
        internal OrderBy optArg(string key, object val){
        
            return this.OptArg(key, val);
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
