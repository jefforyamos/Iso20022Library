﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMCassetteTypeCode.  ISO2002 ID# _W-ddQIqfEeS4a4abTJTSSw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of cassette.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMCassetteTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_W-ddQIqfEeS4a4abTJTSSw")]
public partial class ATMCassetteTypeCodeDropdownSource : EnumMetadataManager<ATMCassetteTypeCode,IATMCassetteTypeCodeDropdownRow,ATMCassetteTypeCodeDropdownRow>
{
    public ATMCassetteTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMCassetteTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
