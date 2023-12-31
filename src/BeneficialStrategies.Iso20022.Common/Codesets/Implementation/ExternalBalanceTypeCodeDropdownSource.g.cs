﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalBalanceTypeCode.  ISO2002 ID# _Nl6j4IakEeeUws0ZryHQ2w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the balance type, as published in an external balance type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalBalanceTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Nl6j4IakEeeUws0ZryHQ2w")]
public partial class ExternalBalanceTypeCodeDropdownSource : EnumMetadataManager<ExternalBalanceTypeCode,IExternalBalanceTypeCodeDropdownRow,ExternalBalanceTypeCodeDropdownRow>
{
    public ExternalBalanceTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalBalanceTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
