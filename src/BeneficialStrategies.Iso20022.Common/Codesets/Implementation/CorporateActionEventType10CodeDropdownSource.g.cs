﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType10Code.  ISO2002 ID# _VbkgYA4pEeKVsZQr6J31Tg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VbkgYA4pEeKVsZQr6J31Tg")]
public partial class CorporateActionEventType10CodeDropdownSource : EnumMetadataManager<CorporateActionEventType10Code,ICorporateActionEventType10CodeDropdownRow,CorporateActionEventType10CodeDropdownRow>
{
    public CorporateActionEventType10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
