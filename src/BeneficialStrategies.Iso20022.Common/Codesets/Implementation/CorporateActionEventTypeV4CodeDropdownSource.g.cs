﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventTypeV4Code.  ISO2002 ID# _BHZogF76EeKuEK-D5sCZIw_2116376083.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the corporate action event type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventTypeV4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BHZogF76EeKuEK-D5sCZIw_2116376083")]
public partial class CorporateActionEventTypeV4CodeDropdownSource : EnumMetadataManager<CorporateActionEventTypeV4Code,ICorporateActionEventTypeV4CodeDropdownRow,CorporateActionEventTypeV4CodeDropdownRow>
{
    public CorporateActionEventTypeV4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventTypeV4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
