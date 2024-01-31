﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OffsetType1Code.  ISO2002 ID# _aOfyV9p-Ed-ak6NoX_4Aeg_-1413993585.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of peg offset or type of discretion offset (e.g. price offset, tick offset etc).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOffsetType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aOfyV9p-Ed-ak6NoX_4Aeg_-1413993585")]
public partial class OffsetType1CodeDropdownSource : EnumMetadataManager<OffsetType1Code,IOffsetType1CodeDropdownRow,OffsetType1CodeDropdownRow>
{
    public OffsetType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OffsetType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
