﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CCPMemberType1Code.  ISO2002 ID# _mKuBsAIJEeutW5-TpeYJhA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of membership the collateral provider holds with the CCP.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICCPMemberType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mKuBsAIJEeutW5-TpeYJhA")]
public partial class CCPMemberType1CodeDropdownSource : EnumMetadataManager<CCPMemberType1Code,ICCPMemberType1CodeDropdownRow,CCPMemberType1CodeDropdownRow>
{
    public CCPMemberType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CCPMemberType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
