// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Hardware Type enum. </summary>
    public readonly partial struct FlexComponentHardwareType : IEquatable<FlexComponentHardwareType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FlexComponentHardwareType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FlexComponentHardwareType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ComputeValue = "COMPUTE";
        private const string CellValue = "CELL";

        /// <summary> Hardware type is Database Server. </summary>
        public static FlexComponentHardwareType Compute { get; } = new FlexComponentHardwareType(ComputeValue);
        /// <summary> Hardware type is Storage Server. </summary>
        public static FlexComponentHardwareType Cell { get; } = new FlexComponentHardwareType(CellValue);
        /// <summary> Determines if two <see cref="FlexComponentHardwareType"/> values are the same. </summary>
        public static bool operator ==(FlexComponentHardwareType left, FlexComponentHardwareType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FlexComponentHardwareType"/> values are not the same. </summary>
        public static bool operator !=(FlexComponentHardwareType left, FlexComponentHardwareType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FlexComponentHardwareType"/>. </summary>
        public static implicit operator FlexComponentHardwareType(string value) => new FlexComponentHardwareType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FlexComponentHardwareType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FlexComponentHardwareType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
