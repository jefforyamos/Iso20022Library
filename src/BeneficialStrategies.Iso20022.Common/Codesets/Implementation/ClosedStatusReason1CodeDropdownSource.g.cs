﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ClosedStatusReason1Code.  ISO2002 ID# _Sx9Z8E_wEeaB8-OWTiMVrQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the closed status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IClosedStatusReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Sx9Z8E_wEeaB8-OWTiMVrQ")]
public partial class ClosedStatusReason1CodeDropdownSource : EnumMetadataManager<ClosedStatusReason1Code,IClosedStatusReason1CodeDropdownRow,ClosedStatusReason1CodeDropdownRow>
{
    public ClosedStatusReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ClosedStatusReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
