﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExemptionCode.  ISO2002 ID# _g7FHoAxyEeqdx6buGpCCQw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of  available exemption codes to strong customer authentication.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExemptionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_g7FHoAxyEeqdx6buGpCCQw")]
public partial class ExemptionCodeDropdownSource : EnumMetadataManager<ExemptionCode,IExemptionCodeDropdownRow,ExemptionCodeDropdownRow>
{
    public ExemptionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExemptionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}