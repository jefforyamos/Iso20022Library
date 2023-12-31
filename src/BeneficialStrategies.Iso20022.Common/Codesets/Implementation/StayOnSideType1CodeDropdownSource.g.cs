﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StayOnSideType1Code.  ISO2002 ID# _wn8Z4A93EeGeV5vP7Mvdig_-1370869444.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates that an order is pegged against the offer/bid at the time of the order submission.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStayOnSideType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_wn8Z4A93EeGeV5vP7Mvdig_-1370869444")]
public partial class StayOnSideType1CodeDropdownSource : EnumMetadataManager<StayOnSideType1Code,IStayOnSideType1CodeDropdownRow,StayOnSideType1CodeDropdownRow>
{
    public StayOnSideType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new StayOnSideType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
