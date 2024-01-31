﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalUnderlyingTradeTransactionTypeCode.  ISO2002 ID# _-MhZAW7iEeKo25nLKvGr8w_650995331.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external commercial reference type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalUnderlyingTradeTransactionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MhZAW7iEeKo25nLKvGr8w_650995331")]
public partial class ExternalUnderlyingTradeTransactionTypeCodeDropdownSource : EnumMetadataManager<ExternalUnderlyingTradeTransactionTypeCode,IExternalUnderlyingTradeTransactionTypeCodeDropdownRow,ExternalUnderlyingTradeTransactionTypeCodeDropdownRow>
{
    public ExternalUnderlyingTradeTransactionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalUnderlyingTradeTransactionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
