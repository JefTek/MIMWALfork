﻿//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="InvalidPowerShellReturnTypeException.cs" company="Microsoft">
//      Copyright (c) Microsoft. All Rights Reserved.
//      Microsoft makes no warranties, expressed or implied.
//      Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
// </copyright>
// <summary>
// InvalidPowerShellReturnTypeException class
// </summary>
//-----------------------------------------------------------------------------------------------------------------------

namespace MicrosoftServices.IdentityManagement.WorkflowActivityLibrary.Exceptions
{
    #region Namespaces Declarations

    using System;
    using System.Globalization;
    using System.Runtime.Serialization;

    #endregion

    /// <summary>
    /// The exception that is thrown when the supplied value could not be matched to a value for the PowerShellReturnType enumeration.
    /// </summary>
    [Serializable]
    public class InvalidPowerShellReturnTypeException : WorkflowActivityLibraryException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPowerShellReturnTypeException"/> class.
        /// </summary>
        public InvalidPowerShellReturnTypeException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPowerShellReturnTypeException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InvalidPowerShellReturnTypeException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPowerShellReturnTypeException"/> class with a specified error message and a reference to the inner exception that caused the current exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="inner">The exception that caused the current exception.</param>
        public InvalidPowerShellReturnTypeException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPowerShellReturnTypeException"/> class.
        /// </summary>
        /// <param name="message">The message format string that describes the error.</param>
        /// <param name="args">The object array that contains zero or more objects to format.</param>
        public InvalidPowerShellReturnTypeException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPowerShellReturnTypeException"/> class.
        /// </summary>
        /// <param name="message">The message format string that describes the error.</param>
        /// <param name="inner">The exception that caused the current exception.</param>
        /// <param name="args">The object array that contains zero or more objects to format.</param>
        public InvalidPowerShellReturnTypeException(string message, Exception inner, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args), inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidPowerShellReturnTypeException"/> class with the serialized object data and the contextual information about the source or destination.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        protected InvalidPowerShellReturnTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}