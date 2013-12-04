﻿//
//  Copyright 2013, Sami M. Kallio
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
using Serializer = ServiceStack.Text.XmlSerializer;

namespace SimplyMobile.Text.ServiceStack
{
    /// <summary>
    /// XML serializer using ServiceStack.Text library
    /// </summary>
    /// <remarks>
    /// 
    /// ServiceStack.Text copyright information
    /// 
    /// Copyright (c) 2007-2011, Demis Bellot, ServiceStack.
    /// http://www.servicestack.net
    /// All rights reserved.
    /// 
    /// https://github.com/ServiceStack/ServiceStack.Text/blob/master/LICENSE
    /// 
    /// </remarks>
    public class XmlSerializer : ITextSerializer
    {
        /// <summary>
        /// Gets the format.
        /// </summary>
        public Format Format
        {
            get {return Format.Xml; }
        }

        /// <summary>
        /// Serializes object to a string
        /// </summary>
        /// <param name="obj">Object to serialize</param>
        /// <returns>Serialized string of the object</returns>
        public string Serialize(object obj)
        {
            return Serializer.SerializeToString(obj);
        }

        /// <summary>
        /// Deserializes string into an object
        /// </summary>
        /// <typeparam name="T">Type of object to serialize to</typeparam>
        /// <param name="data">Serialized object</param>
        /// <returns>Object of type T</returns>
        public T Deserialize<T>(string data)
        {
            return Serializer.DeserializeFromString<T>(data);
        }
    }
}
