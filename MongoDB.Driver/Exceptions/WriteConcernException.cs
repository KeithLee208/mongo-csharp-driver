﻿/* Copyright 2010-2013 10gen Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Runtime.Serialization;

namespace MongoDB.Driver
{
    /// <summary>
    /// Represents a get last error exception.
    /// </summary>
    [Serializable]
#pragma warning disable 618
    public class WriteConcernException : MongoSafeModeException
#pragma warning restore
    {
        // constructors
        /// <summary>
        /// Initializes a new instance of the WriteConcernException class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="writeConcernResult">The command result.</param>
        public WriteConcernException(string message, WriteConcernResult writeConcernResult)
            : base(message, writeConcernResult)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WriteConcernException class (this overload supports deserialization).
        /// </summary>
        /// <param name="info">The SerializationInfo.</param>
        /// <param name="context">The StreamingContext.</param>
        public WriteConcernException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        // public properties
        /// <summary>
        /// Gets the write concern result.
        /// </summary>
        /// <value>
        /// The write concern result.
        /// </value>
        public WriteConcernResult WriteConcernResult
        {
            get { return (WriteConcernResult)CommandResult; }
        }
    }
}
