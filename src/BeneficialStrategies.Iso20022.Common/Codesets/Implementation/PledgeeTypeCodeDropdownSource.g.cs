﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PledgeeTypeCode.  ISO2002 ID# _fynYkE9ZEeSn2-3swbRbzg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of pledgee.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPledgeeTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fynYkE9ZEeSn2-3swbRbzg")]
public partial class PledgeeTypeCodeDropdownSource : EnumMetadataManager<PledgeeTypeCode,IPledgeeTypeCodeDropdownRow,PledgeeTypeCodeDropdownRow>
{
    public PledgeeTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PledgeeTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
