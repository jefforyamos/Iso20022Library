﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResponseStatusCode.  ISO2002 ID# _Y94fANp-Ed-ak6NoX_4Aeg_1785427389.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResponseStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y94fANp-Ed-ak6NoX_4Aeg_1785427389")]
public partial class ResponseStatusCodeDropdownSource : EnumMetadataManager<ResponseStatusCode,IResponseStatusCodeDropdownRow,ResponseStatusCodeDropdownRow>
{
    public ResponseStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResponseStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
