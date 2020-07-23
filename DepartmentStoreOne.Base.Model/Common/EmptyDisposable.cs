using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Base.Model.Common
{
    public class EmptyDisposable : IDisposable
    {
        public static readonly EmptyDisposable Instance = new EmptyDisposable();

        public void Dispose()
        {
            // No-op
        }
    }
}
