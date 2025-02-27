using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Hometown.Grocery.Exchanging.RNHometownGroceryExchanging
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNHometownGroceryExchangingModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNHometownGroceryExchangingModule"/>.
        /// </summary>
        internal RNHometownGroceryExchangingModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNHometownGroceryExchanging";
            }
        }
    }
}
