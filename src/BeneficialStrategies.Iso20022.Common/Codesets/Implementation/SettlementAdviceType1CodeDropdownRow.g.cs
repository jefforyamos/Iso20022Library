﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementAdviceType1Code.  ISO2002 ID# _CEe5kHyiEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of settlement advice.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementAdviceType1CodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementAdviceType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CEe5kHyiEeGWJuGCfvwOsQ")]
public partial class SettlementAdviceType1CodeDropdownRow : EnumMetadataItem<SettlementAdviceType1Code>, ISettlementAdviceType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of settlement advice.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementAdviceType1CodeDropdownRow(SettlementAdviceType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
