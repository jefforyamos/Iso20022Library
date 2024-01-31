﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FailingReason1Code.  ISO2002 ID# _am7gdtp-Ed-ak6NoX_4Aeg_1744847021.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FailingReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IFailingReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_am7gdtp-Ed-ak6NoX_4Aeg_1744847021")]
public partial class FailingReason1CodeDropdownRow : EnumMetadataItem<FailingReason1Code>, IFailingReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FailingReason1CodeDropdownRow(FailingReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
