// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The AlertState. </summary>
    public readonly partial struct AlertState : IEquatable<AlertState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlertState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlertState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NewValue = "New";
        private const string AcknowledgedValue = "Acknowledged";
        private const string ClosedValue = "Closed";

        /// <summary> New. </summary>
        public static AlertState New { get; } = new AlertState(NewValue);
        /// <summary> Acknowledged. </summary>
        public static AlertState Acknowledged { get; } = new AlertState(AcknowledgedValue);
        /// <summary> Closed. </summary>
        public static AlertState Closed { get; } = new AlertState(ClosedValue);
        /// <summary> Determines if two <see cref="AlertState"/> values are the same. </summary>
        public static bool operator ==(AlertState left, AlertState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlertState"/> values are not the same. </summary>
        public static bool operator !=(AlertState left, AlertState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlertState"/>. </summary>
        public static implicit operator AlertState(string value) => new AlertState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlertState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlertState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
