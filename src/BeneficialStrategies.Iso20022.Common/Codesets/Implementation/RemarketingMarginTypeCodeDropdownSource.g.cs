﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RemarketingMarginTypeCode.  ISO2002 ID# _aUJuZ9p-Ed-ak6NoX_4Aeg_1950929666.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of margin.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRemarketingMarginTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aUJuZ9p-Ed-ak6NoX_4Aeg_1950929666")]
public partial class RemarketingMarginTypeCodeDropdownSource : EnumMetadataManager<RemarketingMarginTypeCode,IRemarketingMarginTypeCodeDropdownRow,RemarketingMarginTypeCodeDropdownRow>
{
    public RemarketingMarginTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new RemarketingMarginTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}