﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResolutionStatus1Code.  ISO2002 ID# _ZU0_Zdp-Ed-ak6NoX_4Aeg_188066871.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a resolution in an agenda is still active or has been deleted.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResolutionStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZU0_Zdp-Ed-ak6NoX_4Aeg_188066871")]
public partial class ResolutionStatus1CodeDropdownSource : EnumMetadataManager<ResolutionStatus1Code,IResolutionStatus1CodeDropdownRow,ResolutionStatus1CodeDropdownRow>
{
    public ResolutionStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResolutionStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
