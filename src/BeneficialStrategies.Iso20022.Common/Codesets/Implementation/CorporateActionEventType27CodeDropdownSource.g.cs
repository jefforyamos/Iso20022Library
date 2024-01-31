﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType27Code.  ISO2002 ID# _Tb_dIZSfEeeh5JjedkaA_g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType27CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Tb_dIZSfEeeh5JjedkaA_g")]
public partial class CorporateActionEventType27CodeDropdownSource : EnumMetadataManager<CorporateActionEventType27Code,ICorporateActionEventType27CodeDropdownRow,CorporateActionEventType27CodeDropdownRow>
{
    public CorporateActionEventType27CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType27CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
