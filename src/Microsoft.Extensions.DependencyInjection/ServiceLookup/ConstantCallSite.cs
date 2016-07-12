// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    internal class ConstantCallSite : IServiceCallSite
    {
        internal object DefaultValue { get; }

        public ConstantCallSite(object defaultValue)
        {
            DefaultValue = defaultValue;
        }

        public object Invoke(ServiceProvider provider)
        {
            return DefaultValue;
        }
    }
}
