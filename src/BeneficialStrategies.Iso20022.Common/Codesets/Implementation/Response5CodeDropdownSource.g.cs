﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Response5Code.  ISO2002 ID# _qSYuMNxWEeioifFt1dhnJA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the processing of the message
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResponse5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qSYuMNxWEeioifFt1dhnJA")]
public partial class Response5CodeDropdownSource : EnumMetadataManager<Response5Code,IResponse5CodeDropdownRow,Response5CodeDropdownRow>
{
    public Response5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Response5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
