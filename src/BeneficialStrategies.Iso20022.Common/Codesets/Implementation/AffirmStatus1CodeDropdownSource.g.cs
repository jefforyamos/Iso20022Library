﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AffirmStatus1Code.  ISO2002 ID# _JyV3kHOxEeSG-OV0nXMl5w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the status of the confirmation acknowledgement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAffirmStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JyV3kHOxEeSG-OV0nXMl5w")]
public partial class AffirmStatus1CodeDropdownSource : EnumMetadataManager<AffirmStatus1Code,IAffirmStatus1CodeDropdownRow,AffirmStatus1CodeDropdownRow>
{
    public AffirmStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AffirmStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}