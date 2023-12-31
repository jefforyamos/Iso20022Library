﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PresentmentTypeCode.  ISO2002 ID# _YFIMkEWeEempSe_3C1a9EQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which elements types must be presented in an e-invoice.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPresentmentTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YFIMkEWeEempSe_3C1a9EQ")]
public partial class PresentmentTypeCodeDropdownSource : EnumMetadataManager<PresentmentTypeCode,IPresentmentTypeCodeDropdownRow,PresentmentTypeCodeDropdownRow>
{
    public PresentmentTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PresentmentTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
