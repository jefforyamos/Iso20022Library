﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExchangePolicyCode.  ISO2002 ID# _KR1s8X1DEeCF8NjrBemJWQ_-1574352782.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Exchange policy between parties.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExchangePolicyCodeDropdownSource"/>.
/// Implements <seealso cref="IExchangePolicyCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KR1s8X1DEeCF8NjrBemJWQ_-1574352782")]
public partial class ExchangePolicyCodeDropdownRow : EnumMetadataItem<ExchangePolicyCode>, IExchangePolicyCodeDropdownRow
{
    /// <summary>
    /// Exchange policy between parties.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExchangePolicyCodeDropdownRow(ExchangePolicyCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
