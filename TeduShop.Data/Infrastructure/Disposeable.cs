using System;
using System.Collections.Generic;
using System.Text;

namespace TeduShop.Data.Infrastructure
{
    public class Disposeable : IDisposable
    {
        private bool isDisposed;

        ~Disposeable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose (bool Disposing)
        {
            if(!Disposing && Disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }

        protected virtual void DisposeCore()
        {

        }
    }
}
