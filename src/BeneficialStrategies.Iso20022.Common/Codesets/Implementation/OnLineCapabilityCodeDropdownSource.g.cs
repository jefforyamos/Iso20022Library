﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OnLineCapabilityCode.  ISO2002 ID# _TU5kHAEcEeCQm6a_G2yO_w_1796414491.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// On-line and off-line capabilities of the POI (Point Of Interaction).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOnLineCapabilityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TU5kHAEcEeCQm6a_G2yO_w_1796414491")]
public partial class OnLineCapabilityCodeDropdownSource : EnumMetadataManager<OnLineCapabilityCode,IOnLineCapabilityCodeDropdownRow,OnLineCapabilityCodeDropdownRow>
{
    public OnLineCapabilityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OnLineCapabilityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
