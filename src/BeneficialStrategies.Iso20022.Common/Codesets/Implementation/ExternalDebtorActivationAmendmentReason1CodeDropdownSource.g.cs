﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalDebtorActivationAmendmentReason1Code.  ISO2002 ID# _90jEx_GAEemQ7oqCO5NTQw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the debtor activation amendment reason code, as published in an external debtor activation amendment reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalDebtorActivationAmendmentReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_90jEx_GAEemQ7oqCO5NTQw")]
public partial class ExternalDebtorActivationAmendmentReason1CodeDropdownSource : EnumMetadataManager<ExternalDebtorActivationAmendmentReason1Code,IExternalDebtorActivationAmendmentReason1CodeDropdownRow,ExternalDebtorActivationAmendmentReason1CodeDropdownRow>
{
    public ExternalDebtorActivationAmendmentReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalDebtorActivationAmendmentReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
