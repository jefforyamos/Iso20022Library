﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalDebtorActivationAmendmentReasonCode.  ISO2002 ID# _90jEyPGAEemQ7oqCO5NTQw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the debtor activation amendment reason code, as published in an external debtor activation amendment reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalDebtorActivationAmendmentReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalDebtorActivationAmendmentReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_90jEyPGAEemQ7oqCO5NTQw")]
public partial class ExternalDebtorActivationAmendmentReasonCodeDropdownRow : EnumMetadataItem<ExternalDebtorActivationAmendmentReasonCode>, IExternalDebtorActivationAmendmentReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the debtor activation amendment reason code, as published in an external debtor activation amendment reason code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalDebtorActivationAmendmentReasonCodeDropdownRow(ExternalDebtorActivationAmendmentReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}