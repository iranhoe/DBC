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
    /// Operations used to validate parameters in the methods that must follow the contact.
    /// </summary>
    internal static class ContractOperations
    {
        /// <summary>
        /// Specifies a pre-postcondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        internal static void Requires<TException>(Func<bool> condition, params object[] args) where TException : Exception
        {
            BaseValidation<TException>(condition, args);
        }

        /// <summary>
        /// Specifies a pre-postcondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        internal static void Ensures<TException>(Func<bool> condition, params object[] args) where TException : Exception
        {
            BaseValidation<TException>(condition, args);
        }

        /// <summary>
        /// Specifies a pre-postcondition contract for the enclosing method or property, and throws an exception with the provided message if the condition for the contract fails.
        /// </summary>
        /// <typeparam name="TException">Type of condition to by thrown.</typeparam>
        /// <param name="condition">The conditional expression to test.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        private static void BaseValidation<TException>(Func<bool> condition, object[] args) where TException : Exception
        {
            if (condition == null)
            {
                throw new ArgumentNullException(nameof(condition));
            }

            if (!condition())
            {
                throw Activator.CreateInstance(typeof(TException), args) as TException;
            }
        }
    }
}
