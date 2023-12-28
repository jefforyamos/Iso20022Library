﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TelephonyCallType1Code.  ISO2002 ID# _YOAJsDEvEemzCpWiCwK4aQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the call type
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITelephonyCallType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YOAJsDEvEemzCpWiCwK4aQ")]
public partial class TelephonyCallType1CodeDropdownSource : EnumMetadataManager<TelephonyCallType1Code,ITelephonyCallType1CodeDropdownRow,TelephonyCallType1CodeDropdownRow>
{
    public TelephonyCallType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TelephonyCallType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
