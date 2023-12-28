﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMCassetteType1Code.  ISO2002 ID# _sGm7sIqfEeS4a4abTJTSSw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of cassette.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMCassetteType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sGm7sIqfEeS4a4abTJTSSw")]
public partial class ATMCassetteType1CodeDropdownSource : EnumMetadataManager<ATMCassetteType1Code,IATMCassetteType1CodeDropdownRow,ATMCassetteType1CodeDropdownRow>
{
    public ATMCassetteType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMCassetteType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
