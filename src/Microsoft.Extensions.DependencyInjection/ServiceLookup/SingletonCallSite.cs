// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
    internal class SingletonCallSite : ScopedCallSite
    {
        public SingletonCallSite(IService key, IServiceCallSite serviceCallSite) : base(key, serviceCallSite)
        {
        }

        public override object Invoke(ServiceProvider provider)
        {
            return base.Invoke(provider._root);
        }
    }
}