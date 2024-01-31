﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionEventStatusCode.  ISO2002 ID# _bESK1dp-Ed-ak6NoX_4Aeg_-625919884.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the CA event or option.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionEventStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bESK1dp-Ed-ak6NoX_4Aeg_-625919884")]
public partial class CorporateActionEventStatusCodeDropdownSource : EnumMetadataManager<CorporateActionEventStatusCode,ICorporateActionEventStatusCodeDropdownRow,CorporateActionEventStatusCodeDropdownRow>
{
    public CorporateActionEventStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionEventStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
