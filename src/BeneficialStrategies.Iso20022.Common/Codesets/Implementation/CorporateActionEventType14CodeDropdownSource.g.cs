﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventType14Code.  ISO2002 ID# _IqzhMBEqEeKp2ZN13DI_pA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventType14CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_IqzhMBEqEeKp2ZN13DI_pA")]
public partial class CorporateActionEventType14CodeDropdownSource : EnumMetadataManager<CorporateActionEventType14Code,ICorporateActionEventType14CodeDropdownRow,CorporateActionEventType14CodeDropdownRow>
{
    public CorporateActionEventType14CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventType14CodeDropdownRow(enumValue, memberInfo))
    {
    }
}