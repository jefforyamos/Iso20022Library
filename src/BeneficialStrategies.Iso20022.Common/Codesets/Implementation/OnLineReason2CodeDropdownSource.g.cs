﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OnLineReason2Code.  ISO2002 ID# _3n55AU4LEey_VecAUE-C9Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason to process an online authorisation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOnLineReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3n55AU4LEey_VecAUE-C9Q")]
public partial class OnLineReason2CodeDropdownSource : EnumMetadataManager<OnLineReason2Code,IOnLineReason2CodeDropdownRow,OnLineReason2CodeDropdownRow>
{
    public OnLineReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OnLineReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
