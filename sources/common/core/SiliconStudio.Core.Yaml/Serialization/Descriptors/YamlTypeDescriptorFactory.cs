// Copyright (c) 2015 SharpYaml - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
// -------------------------------------------------------------------------------
// SharpYaml is a fork of YamlDotNet https://github.com/aaubry/YamlDotNet
// published with the following license:
// -------------------------------------------------------------------------------
// 
// Copyright (c) 2008, 2009, 2010, 2011, 2012 Antoine Aubry
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
// of the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using SiliconStudio.Core.Reflection;

namespace SiliconStudio.Core.Yaml.Serialization.Descriptors
{
    /// <summary>
    /// A default implementation for the <see cref="ITypeDescriptorFactory"/>.
    /// </summary>
    public class YamlTypeDescriptorFactory : TypeDescriptorFactoryBase
    {
        private readonly bool emitDefaultValues;
        private readonly IMemberNamingConvention namingConvention;

        /// <summary>
        /// Initializes a new instance of the <see cref="YamlTypeDescriptorFactory" /> class.
        /// </summary>
        /// <param name="attributeRegistry">The attribute registry.</param>
        /// <param name="emitDefaultValues">if set to <c>true</c> [emit default values].</param>
        /// <param name="namingConvention">The naming convention.</param>
        /// <param name="memberComparer">The comparer used to sort members</param>
        /// <exception cref="System.ArgumentNullException">attributeRegistry</exception>
        public YamlTypeDescriptorFactory(IAttributeRegistry attributeRegistry, bool emitDefaultValues, IMemberNamingConvention namingConvention, IComparer<object> memberComparer)
            : base(memberComparer, attributeRegistry)
        {
            if (attributeRegistry == null) throw new ArgumentNullException(nameof(attributeRegistry));
            if (namingConvention == null) throw new ArgumentNullException(nameof(namingConvention));
            this.namingConvention = namingConvention;
            this.emitDefaultValues = emitDefaultValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YamlTypeDescriptorFactory" /> class.
        /// </summary>
        /// <param name="attributeRegistry">The attribute registry.</param>
        /// <exception cref="System.ArgumentNullException">attributeRegistry</exception>
        public YamlTypeDescriptorFactory(IAttributeRegistry attributeRegistry)
            : base(new DefaultKeyComparer(), attributeRegistry)
        {
            namingConvention = new DefaultNamingConvention();
        }

        /// <summary>
        /// Creates a type descriptor for the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>An instance of type descriptor.</returns>
        protected override ITypeDescriptor Create(Type type)
        {
            ObjectDescriptor descriptor;
            // The order of the descriptors here is important

            if (YamlPrimitiveDescriptor.IsPrimitive(type))
            {
                descriptor = new YamlPrimitiveDescriptor(this, type, namingConvention);
            }
            else if (YamlDictionaryDescriptor.IsDictionary(type)) // resolve dictionary before collections, as they are also collections
            {
                // IDictionary
                descriptor = new YamlDictionaryDescriptor(this, type, emitDefaultValues, namingConvention);
            }
            else if (YamlCollectionDescriptor.IsCollection(type))
            {
                // ICollection
                descriptor = new YamlCollectionDescriptor(this, type, emitDefaultValues, namingConvention);
            }
            else if (type.IsArray)
            {
                // array[]
                descriptor = new YamlArrayDescriptor(this, type, namingConvention);
            }
            else if (YamlNullableDescriptor.IsNullable(type))
            {
                descriptor = new YamlNullableDescriptor(this, type, namingConvention);
            }
            else
            {
                // standard object (class or value type)
                descriptor = new ObjectDescriptor(this, type, emitDefaultValues, namingConvention);
            }

            return descriptor;
        }
    }
}
