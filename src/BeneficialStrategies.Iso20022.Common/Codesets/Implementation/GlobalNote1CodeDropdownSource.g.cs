﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GlobalNote1Code.  ISO2002 ID# _hbcAo2liEeGaMcKyqKNRfQ_1398344380.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies if the security will be issued in New Global Note (NGN) or Classical Global Note (CGN).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGlobalNote1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hbcAo2liEeGaMcKyqKNRfQ_1398344380")]
public partial class GlobalNote1CodeDropdownSource : EnumMetadataManager<GlobalNote1Code,IGlobalNote1CodeDropdownRow,GlobalNote1CodeDropdownRow>
{
    public GlobalNote1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new GlobalNote1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
