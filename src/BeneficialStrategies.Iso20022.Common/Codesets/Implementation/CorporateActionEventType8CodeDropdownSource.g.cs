﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType8Code.  ISO2002 ID# _TT-dQQCUEeGL0ezt_jweVA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TT-dQQCUEeGL0ezt_jweVA")]
public partial class CorporateActionEventType8CodeDropdownSource : EnumMetadataManager<CorporateActionEventType8Code,ICorporateActionEventType8CodeDropdownRow,CorporateActionEventType8CodeDropdownRow>
{
    public CorporateActionEventType8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
