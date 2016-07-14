














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

    public partial class Http : ReqlExpr {

    
    
    
/// <summary>
/// <para>Retrieve data from the specified URL over HTTP.  The return type depends on the <code>resultFormat</code> option, which checks the <code>Content-Type</code> of the response by default.</para>
/// </summary>
/// <example><para>Example: Perform an HTTP <code>GET</code> and store the result in a table.</para>
/// <code>r.table('posts').insert(r.http('http://httpbin.org/get')).run(conn, callback)
/// </code></example>
        public Http (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Retrieve data from the specified URL over HTTP.  The return type depends on the <code>resultFormat</code> option, which checks the <code>Content-Type</code> of the response by default.</para>
/// </summary>
/// <example><para>Example: Perform an HTTP <code>GET</code> and store the result in a table.</para>
/// <code>r.table('posts').insert(r.http('http://httpbin.org/get')).run(conn, callback)
/// </code></example>
        public Http (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Retrieve data from the specified URL over HTTP.  The return type depends on the <code>resultFormat</code> option, which checks the <code>Content-Type</code> of the response by default.</para>
/// </summary>
/// <example><para>Example: Perform an HTTP <code>GET</code> and store the result in a table.</para>
/// <code>r.table('posts').insert(r.http('http://httpbin.org/get')).run(conn, callback)
/// </code></example>
        public Http (Arguments args, OptArgs optargs)
         : base(TermType.HTTP, args, optargs) {
        }


    



    
///<summary>
/// "timeout": "T_NUM",
///  "reattempts": "T_NUM",
///  "redirects": "T_NUM",
///  "verify": "T_BOOL",
///  "result_format": "E_RESULT_FORMAT",
///  "method": "E_HTTP_METHOD",
///  "auth": {
///    "type": "E_AUTH_TYPE",
///    "user": "T_STR",
///    "pass": "T_STR"
///  },
///  "params": "T_OBJECT",
///  "header": [
///    "T_ARRAY",
///    "T_OBJECT"
///  ],
///  "data": [
///    "T_STR",
///    "T_OBJECT"
///  ]
///</summary>
        public Http this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new Http (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "timeout": "T_NUM",
///  "reattempts": "T_NUM",
///  "redirects": "T_NUM",
///  "verify": "T_BOOL",
///  "result_format": "E_RESULT_FORMAT",
///  "method": "E_HTTP_METHOD",
///  "auth": {
///    "type": "E_AUTH_TYPE",
///    "user": "T_STR",
///    "pass": "T_STR"
///  },
///  "params": "T_OBJECT",
///  "header": [
///    "T_ARRAY",
///    "T_OBJECT"
///  ],
///  "data": [
///    "T_STR",
///    "T_OBJECT"
///  ]
///</summary>
    public Http this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new Http (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "timeout": "T_NUM",
///  "reattempts": "T_NUM",
///  "redirects": "T_NUM",
///  "verify": "T_BOOL",
///  "result_format": "E_RESULT_FORMAT",
///  "method": "E_HTTP_METHOD",
///  "auth": {
///    "type": "E_AUTH_TYPE",
///    "user": "T_STR",
///    "pass": "T_STR"
///  },
///  "params": "T_OBJECT",
///  "header": [
///    "T_ARRAY",
///    "T_OBJECT"
///  ],
///  "data": [
///    "T_STR",
///    "T_OBJECT"
///  ]
///</summary>
        public Http OptArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new Http (this.Args, newOptArgs);
        }
        internal Http optArg(string key, object val){
        
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
