﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Response3Code.  ISO2002 ID# _nY5LoHuGEeSZrqGdHyoIrw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of the request message or advice message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResponse3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nY5LoHuGEeSZrqGdHyoIrw")]
public partial class Response3CodeDropdownSource : EnumMetadataManager<Response3Code,IResponse3CodeDropdownRow,Response3CodeDropdownRow>
{
    public Response3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Response3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}