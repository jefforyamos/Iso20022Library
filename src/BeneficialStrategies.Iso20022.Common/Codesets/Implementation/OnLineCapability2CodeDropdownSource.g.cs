﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OnLineCapability2Code.  ISO2002 ID# _2-C6gUeqEee9r7QjOdsbFw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// On-line and off-line capabilities of the POI (Point Of Interaction).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOnLineCapability2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2-C6gUeqEee9r7QjOdsbFw")]
public partial class OnLineCapability2CodeDropdownSource : EnumMetadataManager<OnLineCapability2Code,IOnLineCapability2CodeDropdownRow,OnLineCapability2CodeDropdownRow>
{
    public OnLineCapability2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OnLineCapability2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
