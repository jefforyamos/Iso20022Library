﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RetailerService2Code.  ISO2002 ID# _LlmtUNuREeiB5uLfkg9ZJA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of specific services for ServiceRequest
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRetailerService2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_LlmtUNuREeiB5uLfkg9ZJA")]
public partial class RetailerService2CodeDropdownSource : EnumMetadataManager<RetailerService2Code,IRetailerService2CodeDropdownRow,RetailerService2CodeDropdownRow>
{
    public RetailerService2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RetailerService2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}