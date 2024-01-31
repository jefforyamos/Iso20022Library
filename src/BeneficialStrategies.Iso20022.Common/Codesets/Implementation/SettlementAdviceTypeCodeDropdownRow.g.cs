﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementAdviceTypeCode.  ISO2002 ID# _JpEXQHygEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of settlement advice.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementAdviceTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementAdviceTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JpEXQHygEeGWJuGCfvwOsQ")]
public partial class SettlementAdviceTypeCodeDropdownRow : EnumMetadataItem<SettlementAdviceTypeCode>, ISettlementAdviceTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of settlement advice.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementAdviceTypeCodeDropdownRow(SettlementAdviceTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
