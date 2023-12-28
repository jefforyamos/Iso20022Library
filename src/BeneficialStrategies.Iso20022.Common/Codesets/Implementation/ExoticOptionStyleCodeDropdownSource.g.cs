﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExoticOptionStyleCode.  ISO2002 ID# _WkTlYcRxEeOg-a7zWL_U0A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the option style.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExoticOptionStyleCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WkTlYcRxEeOg-a7zWL_U0A")]
public partial class ExoticOptionStyleCodeDropdownSource : EnumMetadataManager<ExoticOptionStyleCode,IExoticOptionStyleCodeDropdownRow,ExoticOptionStyleCodeDropdownRow>
{
    public ExoticOptionStyleCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExoticOptionStyleCodeDropdownRow(enumValue, memberInfo))
    {
    }
}