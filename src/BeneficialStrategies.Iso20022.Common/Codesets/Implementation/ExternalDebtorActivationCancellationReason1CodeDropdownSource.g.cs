﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalDebtorActivationCancellationReason1Code.  ISO2002 ID# _90jEy_GAEemQ7oqCO5NTQw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the debtor activation cancellation reason code, as published in an external debtor activation cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalDebtorActivationCancellationReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_90jEy_GAEemQ7oqCO5NTQw")]
public partial class ExternalDebtorActivationCancellationReason1CodeDropdownSource : EnumMetadataManager<ExternalDebtorActivationCancellationReason1Code,IExternalDebtorActivationCancellationReason1CodeDropdownRow,ExternalDebtorActivationCancellationReason1CodeDropdownRow>
{
    public ExternalDebtorActivationCancellationReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalDebtorActivationCancellationReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
