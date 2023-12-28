﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalTradeTransactionCondition1Code.  ISO2002 ID# __2iXdNojEeC60axPepSq7g_398197023.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external Trade Transaction Condition code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalTradeTransactionCondition1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__2iXdNojEeC60axPepSq7g_398197023")]
public partial class ExternalTradeTransactionCondition1CodeDropdownSource : EnumMetadataManager<ExternalTradeTransactionCondition1Code,IExternalTradeTransactionCondition1CodeDropdownRow,ExternalTradeTransactionCondition1CodeDropdownRow>
{
    public ExternalTradeTransactionCondition1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalTradeTransactionCondition1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
