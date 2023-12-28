﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TargetMarket2Code.  ISO2002 ID# _t_HHUNdjEeibyvRfU9vJ7w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a financial product is in scope of a target market parameter.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITargetMarket2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_t_HHUNdjEeibyvRfU9vJ7w")]
public partial class TargetMarket2CodeDropdownSource : EnumMetadataManager<TargetMarket2Code,ITargetMarket2CodeDropdownRow,TargetMarket2CodeDropdownRow>
{
    public TargetMarket2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TargetMarket2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}