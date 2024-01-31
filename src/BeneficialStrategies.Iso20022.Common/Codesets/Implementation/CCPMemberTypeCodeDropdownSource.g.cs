﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CCPMemberTypeCode.  ISO2002 ID# _DohbkAGeEeutW5-TpeYJhA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of membership the collateral provider holds with the CCP.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICCPMemberTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DohbkAGeEeutW5-TpeYJhA")]
public partial class CCPMemberTypeCodeDropdownSource : EnumMetadataManager<CCPMemberTypeCode,ICCPMemberTypeCodeDropdownRow,CCPMemberTypeCodeDropdownRow>
{
    public CCPMemberTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CCPMemberTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
