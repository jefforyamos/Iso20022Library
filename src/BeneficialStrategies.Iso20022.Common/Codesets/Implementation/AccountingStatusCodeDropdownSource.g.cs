﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AccountingStatusCode.  ISO2002 ID# _Kl0T0CDEEeWPMvNwVtiMsA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the accounting status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAccountingStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Kl0T0CDEEeWPMvNwVtiMsA")]
public partial class AccountingStatusCodeDropdownSource : EnumMetadataManager<AccountingStatusCode,IAccountingStatusCodeDropdownRow,AccountingStatusCodeDropdownRow>
{
    public AccountingStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AccountingStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
