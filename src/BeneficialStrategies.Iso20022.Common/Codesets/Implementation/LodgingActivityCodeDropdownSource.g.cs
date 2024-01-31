﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for LodgingActivityCode.  ISO2002 ID# _U7-5MGMbEeexSYCBvAp_qA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of lodging activity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ILodgingActivityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_U7-5MGMbEeexSYCBvAp_qA")]
public partial class LodgingActivityCodeDropdownSource : EnumMetadataManager<LodgingActivityCode,ILodgingActivityCodeDropdownRow,LodgingActivityCodeDropdownRow>
{
    public LodgingActivityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new LodgingActivityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
