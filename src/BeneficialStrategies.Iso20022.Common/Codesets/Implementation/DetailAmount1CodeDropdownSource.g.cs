﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DetailAmount1Code.  ISO2002 ID# _ad8DwBbyEeit0dtP9bTmEg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of detail amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDetailAmount1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ad8DwBbyEeit0dtP9bTmEg")]
public partial class DetailAmount1CodeDropdownSource : EnumMetadataManager<DetailAmount1Code,IDetailAmount1CodeDropdownRow,DetailAmount1CodeDropdownRow>
{
    public DetailAmount1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DetailAmount1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
