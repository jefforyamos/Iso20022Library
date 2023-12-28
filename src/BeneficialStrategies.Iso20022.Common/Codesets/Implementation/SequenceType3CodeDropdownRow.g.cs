﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SequenceType3Code.  ISO2002 ID# _t90OI1kyEeGeoaLUQk__nA_2097556198.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the current transaction that belongs to a sequence of transactions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SequenceType3CodeDropdownSource"/>.
/// Implements <seealso cref="ISequenceType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_t90OI1kyEeGeoaLUQk__nA_2097556198")]
public partial class SequenceType3CodeDropdownRow : EnumMetadataItem<SequenceType3Code>, ISequenceType3CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of the current transaction that belongs to a sequence of transactions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SequenceType3CodeDropdownRow(SequenceType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
