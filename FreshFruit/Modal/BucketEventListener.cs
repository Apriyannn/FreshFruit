using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruit.Modal
{
    interface BucketEventListener
    {
        void onSucceed(string message);
        void onFailed(string message);
    }
}
