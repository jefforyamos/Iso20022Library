﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SenderBusinessRoleCode.  ISO2002 ID# _XOtxgFV0Eea1MPROA61PoQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether account owner or account servicer sends the message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISenderBusinessRoleCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XOtxgFV0Eea1MPROA61PoQ")]
public partial class SenderBusinessRoleCodeDropdownSource : EnumMetadataManager<SenderBusinessRoleCode,ISenderBusinessRoleCodeDropdownRow,SenderBusinessRoleCodeDropdownRow>
{
    public SenderBusinessRoleCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SenderBusinessRoleCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
