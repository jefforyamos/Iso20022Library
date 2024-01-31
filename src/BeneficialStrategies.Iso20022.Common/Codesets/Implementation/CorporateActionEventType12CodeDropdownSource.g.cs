﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType12Code.  ISO2002 ID# _VU4AcA8DEeKhfswDSmpBfA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VU4AcA8DEeKhfswDSmpBfA")]
public partial class CorporateActionEventType12CodeDropdownSource : EnumMetadataManager<CorporateActionEventType12Code,ICorporateActionEventType12CodeDropdownRow,CorporateActionEventType12CodeDropdownRow>
{
    public CorporateActionEventType12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
