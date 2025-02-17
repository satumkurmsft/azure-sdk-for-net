// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The signing or hashing algorithm. </summary>
    public readonly partial struct SigningAlgorithm : IEquatable<SigningAlgorithm>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SigningAlgorithm"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SigningAlgorithm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string DefaultValue = "Default";
        private const string Sha1Value = "SHA1";
        private const string Sha2256Value = "SHA2256";
        private const string Sha2384Value = "SHA2384";
        private const string Sha2512Value = "SHA2512";

        /// <summary> NotSpecified. </summary>
        public static SigningAlgorithm NotSpecified { get; } = new SigningAlgorithm(NotSpecifiedValue);
        /// <summary> Default. </summary>
        public static SigningAlgorithm Default { get; } = new SigningAlgorithm(DefaultValue);
        /// <summary> SHA1. </summary>
        public static SigningAlgorithm Sha1 { get; } = new SigningAlgorithm(Sha1Value);
        /// <summary> SHA2256. </summary>
        public static SigningAlgorithm Sha2256 { get; } = new SigningAlgorithm(Sha2256Value);
        /// <summary> SHA2384. </summary>
        public static SigningAlgorithm Sha2384 { get; } = new SigningAlgorithm(Sha2384Value);
        /// <summary> SHA2512. </summary>
        public static SigningAlgorithm Sha2512 { get; } = new SigningAlgorithm(Sha2512Value);
        /// <summary> Determines if two <see cref="SigningAlgorithm"/> values are the same. </summary>
        public static bool operator ==(SigningAlgorithm left, SigningAlgorithm right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SigningAlgorithm"/> values are not the same. </summary>
        public static bool operator !=(SigningAlgorithm left, SigningAlgorithm right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SigningAlgorithm"/>. </summary>
        public static implicit operator SigningAlgorithm(string value) => new SigningAlgorithm(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SigningAlgorithm other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SigningAlgorithm other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
