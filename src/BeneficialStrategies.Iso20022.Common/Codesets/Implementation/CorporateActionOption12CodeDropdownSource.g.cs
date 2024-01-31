﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionOption12Code.  ISO2002 ID# _mc56nOasEemtTOaHuc_63w.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of corporate action options.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionOption12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mc56nOasEemtTOaHuc_63w")]
public partial class CorporateActionOption12CodeDropdownSource : EnumMetadataManager<CorporateActionOption12Code,ICorporateActionOption12CodeDropdownRow,CorporateActionOption12CodeDropdownRow>
{
    public CorporateActionOption12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionOption12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
