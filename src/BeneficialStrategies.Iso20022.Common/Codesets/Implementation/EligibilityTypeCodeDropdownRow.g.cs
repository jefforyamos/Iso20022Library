﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for EligibilityTypeCode.  ISO2002 ID# _jBmr4e5NEeCisYr99QEiWA_-1187231304.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of eligibility.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="EligibilityTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IEligibilityTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jBmr4e5NEeCisYr99QEiWA_-1187231304")]
public partial class EligibilityTypeCodeDropdownRow : EnumMetadataItem<EligibilityTypeCode>, IEligibilityTypeCodeDropdownRow
{
    /// <summary>
    /// Defines the type of eligibility.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EligibilityTypeCodeDropdownRow(EligibilityTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
