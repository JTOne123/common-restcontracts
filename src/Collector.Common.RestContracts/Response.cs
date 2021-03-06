﻿namespace Collector.Common.RestContracts
{
    /// <summary>
    /// Generic REST response inspired by the Google JSON Style Guide https://google.github.io/styleguide/jsoncstyleguide.xml.
    /// </summary>
    /// <typeparam name="T">The type of response.</typeparam>
    public class Response<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Response{T}" /> class.
        /// </summary>
        /// <param name="apiVersion">The api version.</param>
        /// <param name="context">The context.</param>
        /// <param name="correlationId">The correlation correlationId.</param>
        /// <param name="data">The response data.</param>
        public Response(string apiVersion, string context, string correlationId, T data)
            : this(apiVersion, correlationId, context)
        {
            Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response{T}"/> class.
        /// </summary>
        /// <param name="apiVersion">The api version.</param>
        /// <param name="context">The context.</param>
        /// <param name="correlationId">The correlation correlationId.</param>
        /// <param name="error">The error.</param>
        public Response(string apiVersion, string context, string correlationId, Error error)
            : this(apiVersion, correlationId, context)
        {
            Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response{T}"/> class.
        /// </summary>
        public Response()
        {            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response{T}"/> class.
        /// </summary>
        /// <param name="apiVersion">The api version.</param>
        /// <param name="context">The context.</param>
        /// <param name="correlationId">The correlation correlationId.</param>
        private Response(string apiVersion, string correlationId, string context)
        {
            ApiVersion = apiVersion;
            Context = context;
            CorrelationId = correlationId;
        }

        /// <summary>
        /// Gets the api version.
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets the context.
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// Gets the response data.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Gets the error.
        /// </summary>
        public Error Error { get; set; }

        /// <summary>
        /// Gets the correlation correlationId.
        /// </summary>
        public string CorrelationId { get; set; }
    }
}