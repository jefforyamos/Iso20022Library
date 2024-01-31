﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalVerificationReasonCode.  ISO2002 ID# _jcPvQBLeEeumtumXS98aGg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external verification reason code, as published in an external verification code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalVerificationReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalVerificationReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jcPvQBLeEeumtumXS98aGg")]
public partial class ExternalVerificationReasonCodeDropdownRow : EnumMetadataItem<ExternalVerificationReasonCode>, IExternalVerificationReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the external verification reason code, as published in an external verification code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalVerificationReasonCodeDropdownRow(ExternalVerificationReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
