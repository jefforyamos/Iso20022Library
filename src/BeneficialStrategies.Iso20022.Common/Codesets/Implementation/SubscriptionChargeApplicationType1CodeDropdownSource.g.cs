﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SubscriptionChargeApplicationType1Code.  ISO2002 ID# _10dH5TL3EeKU9IrkkToqcw_-294723543.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the cash debit for the subscription charge is made immediately or accumulated.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISubscriptionChargeApplicationType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_10dH5TL3EeKU9IrkkToqcw_-294723543")]
public partial class SubscriptionChargeApplicationType1CodeDropdownSource : EnumMetadataManager<SubscriptionChargeApplicationType1Code,ISubscriptionChargeApplicationType1CodeDropdownRow,SubscriptionChargeApplicationType1CodeDropdownRow>
{
    public SubscriptionChargeApplicationType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SubscriptionChargeApplicationType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
