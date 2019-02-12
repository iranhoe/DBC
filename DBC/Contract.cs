// <copyright file="StringConstants.cs" company="Iran Corrales Becerra">
//    This file is part of DBC library.
//
//    NContracts library is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    NContracts library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with NContracts library.  If not, see https://www.gnu.org/licenses/
// </copyright>
namespace NContracts
{
    using System;

    /// <summary>
    /// Class used to validate parameters in the methods that must follow the contact.
    /// </summary>
    public static partial class Contract
    {
        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <param name="condition">The conditional expression to test.</param>
        public static void Requires(bool condition) => ContractOperations.Requires<Exception>(() => condition, StringConstants.MessageRequiresError);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <param name="condition">The conditional expression to test.</param>
        /// /// <param name="message">The message that describes the error.</param>
        public static void Requires(bool condition, string message) => ContractOperations.Requires<Exception>(() => condition, message);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        public static void Requires<TException>(bool condition) where TException : Exception => ContractOperations.Requires<TException>(() => condition, StringConstants.MessageRequiresError);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="message">The message that describes the error.</param>
        public static void Requires<TException>(bool condition, string message) where TException : Exception => ContractOperations.Requires<TException>(() => condition, message);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void Requires<TException>(bool condition, params object[] args) where TException : Exception => ContractOperations.Requires<TException>(() => condition, args);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <param name="condition">The conditional expression to test.</param>
        public static void Requires(Func<bool> condition) => ContractOperations.Requires<Exception>(condition, StringConstants.MessageRequiresError);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="message">The message that describes the error.</param>
        public static void Requires(Func<bool> condition, string message) => ContractOperations.Requires<Exception>(condition, message);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        public static void Requires<TException>(Func<bool> condition) where TException : Exception => ContractOperations.Requires<TException>(condition, StringConstants.MessageRequiresError);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="message">The message that describes the error.</param>
        public static void Requires<TException>(Func<bool> condition, string message) where TException : Exception => ContractOperations.Requires<TException>(condition, message);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void Requires<TException>(Func<bool> condition, params object[] args) where TException : Exception => ContractOperations.Requires<TException>(condition, args);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <param name="condition">The conditional expression to test.</param>
        public static void Ensures(bool condition) => ContractOperations.Ensures<Exception>(() => condition, StringConstants.MessageRequiresError);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <param name="condition">The conditional expression to test.</param>
        /// /// <param name="message">The message that describes the error.</param>
        public static void Ensures(bool condition, string message) => ContractOperations.Ensures<Exception>(() => condition, message);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        public static void Ensures<TException>(bool condition) where TException : Exception => ContractOperations.Ensures<TException>(() => condition, StringConstants.MessageRequiresError);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="message">The message that describes the error.</param>
        public static void Ensures<TException>(bool condition, string message) where TException : Exception => ContractOperations.Ensures<TException>(() => condition, message);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void Ensures<TException>(bool condition, params object[] args) where TException : Exception => ContractOperations.Ensures<TException>(() => condition, args);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <param name="condition">The conditional expression to test.</param>
        public static void Ensures(Func<bool> condition) => ContractOperations.Ensures<Exception>(condition, StringConstants.MessageRequiresError);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="message">The message that describes the error.</param>
        public static void Ensures(Func<bool> condition, string message) => ContractOperations.Ensures<Exception>(condition, message);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        public static void Ensures<TException>(Func<bool> condition) where TException : Exception => ContractOperations.Ensures<TException>(condition, StringConstants.MessageRequiresError);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="message">The message that describes the error.</param>
        public static void Ensures<TException>(Func<bool> condition, string message) where TException : Exception => ContractOperations.Ensures<TException>(condition, message);

        /// <summary>
        /// Specifies a precondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        public static void Ensures<TException>(Func<bool> condition, params object[] args) where TException : Exception => ContractOperations.Ensures<TException>(condition, args);
    }
}
