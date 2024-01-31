﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DetailAmountCode.  ISO2002 ID# _BM4rsBbxEeit0dtP9bTmEg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of detail amount
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDetailAmountCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BM4rsBbxEeit0dtP9bTmEg")]
public partial class DetailAmountCodeDropdownSource : EnumMetadataManager<DetailAmountCode,IDetailAmountCodeDropdownRow,DetailAmountCodeDropdownRow>
{
    public DetailAmountCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DetailAmountCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
