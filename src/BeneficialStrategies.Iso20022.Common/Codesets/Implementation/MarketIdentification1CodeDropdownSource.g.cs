﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MarketIdentification1Code.  ISO2002 ID# _9JOc0MObEeWiEtRBUJSIaA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of market identification code which is being defined.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMarketIdentification1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_9JOc0MObEeWiEtRBUJSIaA")]
public partial class MarketIdentification1CodeDropdownSource : EnumMetadataManager<MarketIdentification1Code,IMarketIdentification1CodeDropdownRow,MarketIdentification1CodeDropdownRow>
{
    public MarketIdentification1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MarketIdentification1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
