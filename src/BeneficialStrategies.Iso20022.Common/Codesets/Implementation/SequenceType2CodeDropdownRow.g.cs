﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SequenceType2Code.  ISO2002 ID# _ZKPgB9p-Ed-ak6NoX_4Aeg_868377274.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a once off transaction is covered or whether recurring transactions are covered.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SequenceType2CodeDropdownSource"/>.
/// Implements <seealso cref="ISequenceType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZKPgB9p-Ed-ak6NoX_4Aeg_868377274")]
public partial class SequenceType2CodeDropdownRow : EnumMetadataItem<SequenceType2Code>, ISequenceType2CodeDropdownRow
{
    /// <summary>
    /// Specifies whether a once off transaction is covered or whether recurring transactions are covered.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SequenceType2CodeDropdownRow(SequenceType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
