﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TaxationBasis5Code.  ISO2002 ID# _pfehUDkTEeahTcrfPSjpxA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the tax or charge basis.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITaxationBasis5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pfehUDkTEeahTcrfPSjpxA")]
public partial class TaxationBasis5CodeDropdownSource : EnumMetadataManager<TaxationBasis5Code,ITaxationBasis5CodeDropdownRow,TaxationBasis5CodeDropdownRow>
{
    public TaxationBasis5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TaxationBasis5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
