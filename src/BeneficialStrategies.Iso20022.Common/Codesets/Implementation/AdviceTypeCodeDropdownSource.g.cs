﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AdviceTypeCode.  ISO2002 ID# _AuwW8NomEembTrt_WixjyQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of advice to provide back in the report.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAdviceTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AuwW8NomEembTrt_WixjyQ")]
public partial class AdviceTypeCodeDropdownSource : EnumMetadataManager<AdviceTypeCode,IAdviceTypeCodeDropdownRow,AdviceTypeCodeDropdownRow>
{
    public AdviceTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AdviceTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
