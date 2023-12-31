﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResponseMode1Code.  ISO2002 ID# _OqZvQN6rEeiwsev40qZGEQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Message response awaited by the initiator of the Request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResponseMode1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OqZvQN6rEeiwsev40qZGEQ")]
public partial class ResponseMode1CodeDropdownSource : EnumMetadataManager<ResponseMode1Code,IResponseMode1CodeDropdownRow,ResponseMode1CodeDropdownRow>
{
    public ResponseMode1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResponseMode1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
