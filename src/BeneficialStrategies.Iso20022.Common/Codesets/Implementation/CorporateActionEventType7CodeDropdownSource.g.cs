﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType7Code.  ISO2002 ID# _xWVn4ffbEd-5M-tMFgHEdw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xWVn4ffbEd-5M-tMFgHEdw")]
public partial class CorporateActionEventType7CodeDropdownSource : EnumMetadataManager<CorporateActionEventType7Code,ICorporateActionEventType7CodeDropdownRow,CorporateActionEventType7CodeDropdownRow>
{
    public CorporateActionEventType7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
