﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalBalanceSubTypeCode.  ISO2002 ID# _vBuz4I8qEeeBmcwCTnMfBg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the balance sub-type, as published in an external balance sub-type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalBalanceSubTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vBuz4I8qEeeBmcwCTnMfBg")]
public partial class ExternalBalanceSubTypeCodeDropdownSource : EnumMetadataManager<ExternalBalanceSubTypeCode,IExternalBalanceSubTypeCodeDropdownRow,ExternalBalanceSubTypeCodeDropdownRow>
{
    public ExternalBalanceSubTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalBalanceSubTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
