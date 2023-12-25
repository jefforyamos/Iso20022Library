﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SubscriptionRequestCode.  ISO2002 ID# _ZQpqCNp-Ed-ak6NoX_4Aeg_336259528.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of subscription to market data.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISubscriptionRequestCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZQpqCNp-Ed-ak6NoX_4Aeg_336259528")]
public partial class SubscriptionRequestCodeDropdownSource : EnumMetadataManager<SubscriptionRequestCode,ISubscriptionRequestCodeDropdownRow,SubscriptionRequestCodeDropdownRow>
{
    public SubscriptionRequestCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SubscriptionRequestCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
