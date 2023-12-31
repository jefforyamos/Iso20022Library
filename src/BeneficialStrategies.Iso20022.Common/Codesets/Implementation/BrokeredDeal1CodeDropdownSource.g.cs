﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BrokeredDeal1Code.  ISO2002 ID# _jreAAHvREeWrWYBng3OpVw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the transaction is arranged via a third party broker or not.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBrokeredDeal1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jreAAHvREeWrWYBng3OpVw")]
public partial class BrokeredDeal1CodeDropdownSource : EnumMetadataManager<BrokeredDeal1Code,IBrokeredDeal1CodeDropdownRow,BrokeredDeal1CodeDropdownRow>
{
    public BrokeredDeal1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BrokeredDeal1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
