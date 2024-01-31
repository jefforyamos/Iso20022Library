﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradingVenue1Code.  ISO2002 ID# _miosoF0gEeWErPfQ7BYx8A.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a trading venue which must use the market identification code (MIC).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradingVenue1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_miosoF0gEeWErPfQ7BYx8A")]
public partial class TradingVenue1CodeDropdownSource : EnumMetadataManager<TradingVenue1Code,ITradingVenue1CodeDropdownRow,TradingVenue1CodeDropdownRow>
{
    public TradingVenue1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradingVenue1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
