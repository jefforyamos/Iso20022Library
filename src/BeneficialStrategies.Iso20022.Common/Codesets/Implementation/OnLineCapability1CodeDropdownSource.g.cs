﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OnLineCapability1Code.  ISO2002 ID# _TTZvTgEcEeCQm6a_G2yO_w_-1858574023.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// On-line and off-line capabilities of the POI (Point Of Interaction).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOnLineCapability1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TTZvTgEcEeCQm6a_G2yO_w_-1858574023")]
public partial class OnLineCapability1CodeDropdownSource : EnumMetadataManager<OnLineCapability1Code,IOnLineCapability1CodeDropdownRow,OnLineCapability1CodeDropdownRow>
{
    public OnLineCapability1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OnLineCapability1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
