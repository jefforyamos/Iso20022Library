﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Response9Code.  ISO2002 ID# _7CBR4Q1PEeqjM-rxn3HuXQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the performed service.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResponse9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7CBR4Q1PEeqjM-rxn3HuXQ")]
public partial class Response9CodeDropdownSource : EnumMetadataManager<Response9Code,IResponse9CodeDropdownRow,Response9CodeDropdownRow>
{
    public Response9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Response9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
