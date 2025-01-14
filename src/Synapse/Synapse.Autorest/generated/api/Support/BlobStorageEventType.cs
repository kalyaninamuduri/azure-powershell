// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support
{

    /// <summary>The name of blob storage event type to process.</summary>
    public partial struct BlobStorageEventType :
        System.IEquatable<BlobStorageEventType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType MicrosoftStorageBlobCreated = @"Microsoft.Storage.BlobCreated";

        public static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType MicrosoftStorageBlobRenamed = @"Microsoft.Storage.BlobRenamed";

        /// <summary>the value for an instance of the <see cref="BlobStorageEventType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="BlobStorageEventType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private BlobStorageEventType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to BlobStorageEventType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="BlobStorageEventType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new BlobStorageEventType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type BlobStorageEventType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type BlobStorageEventType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is BlobStorageEventType && Equals((BlobStorageEventType)obj);
        }

        /// <summary>Returns hashCode for enum BlobStorageEventType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for BlobStorageEventType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to BlobStorageEventType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="BlobStorageEventType" />.</param>

        public static implicit operator BlobStorageEventType(string value)
        {
            return new BlobStorageEventType(value);
        }

        /// <summary>Implicit operator to convert BlobStorageEventType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="BlobStorageEventType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum BlobStorageEventType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType e1, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum BlobStorageEventType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType e1, Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType e2)
        {
            return e2.Equals(e1);
        }
    }
}