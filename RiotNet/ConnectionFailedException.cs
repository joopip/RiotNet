﻿using System;
using System.Runtime.Serialization;
using System.Security.Permissions;
using RestSharp;

namespace RiotNet
{
    /// <summary>
    /// Represents an error that occurs when a REST request fails because it could not to connect to the server.
    /// </summary>
    public class ConnectionFailedException : RestException
    {
        /// <summary>
        /// Creates a new <see cref="ConnectionFailedException"/> instance.
        /// </summary>
        public ConnectionFailedException()
            : this(null)
        { }

        /// <summary>
        /// Creates a new <see cref="ConnectionFailedException"/> instance.
        /// </summary>
        /// <param name="response">The response.</param>
        public ConnectionFailedException(IRestResponse response)
            : this(response, (Exception)null)
        { }

        /// <summary>
        /// Creates a new <see cref="ConnectionFailedException"/> instance.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public ConnectionFailedException(IRestResponse response, Exception innerException)
            : base(response, "Failed to connect to the server.", innerException)
        { }

        /// <summary>
        /// Creates a new <see cref="ConnectionFailedException"/> instance.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="message">A message that describes the error.</param>
        public ConnectionFailedException(IRestResponse response, string message)
            : base(response, message)
        { }

        /// <summary>
        /// Creates a new <see cref="ConnectionFailedException"/> instance.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="message">A message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public ConnectionFailedException(IRestResponse response, string message, Exception innerException)
            : base(response, message, innerException)
        { }

        /// <summary>
        /// Creates a new <see cref="ConnectionFailedException"/> instance.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        protected ConnectionFailedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
