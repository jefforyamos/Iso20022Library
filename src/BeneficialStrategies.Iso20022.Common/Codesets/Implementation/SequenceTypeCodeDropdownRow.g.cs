﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SequenceTypeCode.  ISO2002 ID# _ZKZRAdp-Ed-ak6NoX_4Aeg_195863481.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the current transaction that belongs to a sequence of transactions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SequenceTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ISequenceTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZKZRAdp-Ed-ak6NoX_4Aeg_195863481")]
public partial class SequenceTypeCodeDropdownRow : EnumMetadataItem<SequenceTypeCode>, ISequenceTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of the current transaction that belongs to a sequence of transactions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SequenceTypeCodeDropdownRow(SequenceTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
