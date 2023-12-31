﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType2Code.  ISO2002 ID# _bEu2xNp-Ed-ak6NoX_4Aeg_-976076267.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the CA event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bEu2xNp-Ed-ak6NoX_4Aeg_-976076267")]
public partial class CorporateActionEventType2CodeDropdownSource : EnumMetadataManager<CorporateActionEventType2Code,ICorporateActionEventType2CodeDropdownRow,CorporateActionEventType2CodeDropdownRow>
{
    public CorporateActionEventType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
