﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Algorithm3Code.  ISO2002 ID# _MxVe8AipEeKn9O5oyej_zw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cryptographic algorithms for the MAC (Message Authentication Code).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Algorithm3CodeDropdownSource"/>.
/// Implements <seealso cref="IAlgorithm3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MxVe8AipEeKn9O5oyej_zw")]
public partial class Algorithm3CodeDropdownRow : EnumMetadataItem<Algorithm3Code>, IAlgorithm3CodeDropdownRow
{
    /// <summary>
    /// Cryptographic algorithms for the MAC (Message Authentication Code).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Algorithm3CodeDropdownRow(Algorithm3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
