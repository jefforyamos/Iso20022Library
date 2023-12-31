﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FraudReportingActionCode.  ISO2002 ID# _ndM2AHbBEeef9c2nwgY9Xw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of fraud reporting.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FraudReportingActionCodeDropdownSource"/>.
/// Implements <seealso cref="IFraudReportingActionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ndM2AHbBEeef9c2nwgY9Xw")]
public partial class FraudReportingActionCodeDropdownRow : EnumMetadataItem<FraudReportingActionCode>, IFraudReportingActionCodeDropdownRow
{
    /// <summary>
    /// Type of fraud reporting.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FraudReportingActionCodeDropdownRow(FraudReportingActionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
