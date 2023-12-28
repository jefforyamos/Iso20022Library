﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMMediaType1Code.  ISO2002 ID# _-L27wIqdEeS4a4abTJTSSw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of media inside an ATM cassette.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMMediaType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-L27wIqdEeS4a4abTJTSSw")]
public partial class ATMMediaType1CodeDropdownSource : EnumMetadataManager<ATMMediaType1Code,IATMMediaType1CodeDropdownRow,ATMMediaType1CodeDropdownRow>
{
    public ATMMediaType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMMediaType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
