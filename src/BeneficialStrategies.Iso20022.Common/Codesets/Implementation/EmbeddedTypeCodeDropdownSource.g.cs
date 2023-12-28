﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EmbeddedTypeCode.  ISO2002 ID# _w783gIcPEeu4rpsqTt37Pg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the list of codes applicable to embedded option types.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEmbeddedTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_w783gIcPEeu4rpsqTt37Pg")]
public partial class EmbeddedTypeCodeDropdownSource : EnumMetadataManager<EmbeddedTypeCode,IEmbeddedTypeCodeDropdownRow,EmbeddedTypeCodeDropdownRow>
{
    public EmbeddedTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EmbeddedTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}