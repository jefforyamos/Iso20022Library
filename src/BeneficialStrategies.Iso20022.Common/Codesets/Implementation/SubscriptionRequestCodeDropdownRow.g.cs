﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SubscriptionRequestCode.  ISO2002 ID# _ZQpqCNp-Ed-ak6NoX_4Aeg_336259528.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of subscription to market data.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SubscriptionRequestCodeDropdownSource"/>.
/// Implements <seealso cref="ISubscriptionRequestCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZQpqCNp-Ed-ak6NoX_4Aeg_336259528")]
public partial class SubscriptionRequestCodeDropdownRow : EnumMetadataItem<SubscriptionRequestCode>, ISubscriptionRequestCodeDropdownRow
{
    /// <summary>
    /// Type of subscription to market data.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SubscriptionRequestCodeDropdownRow(SubscriptionRequestCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
