﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GateHoldBackCode.  ISO2002 ID# _ygvPwDwvEeaFzejt0Yw_3A.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of hold back on redemption proceeds.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGateHoldBackCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ygvPwDwvEeaFzejt0Yw_3A")]
public partial class GateHoldBackCodeDropdownSource : EnumMetadataManager<GateHoldBackCode,IGateHoldBackCodeDropdownRow,GateHoldBackCodeDropdownRow>
{
    public GateHoldBackCodeDropdownSource()
        : base( (enumValue, memberInfo) => new GateHoldBackCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
