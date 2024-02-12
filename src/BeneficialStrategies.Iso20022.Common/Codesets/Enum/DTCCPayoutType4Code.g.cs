﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCCPayoutType4Code.  ISO2002 ID# _qa7c8KFcEeSK_vfd3NHBGg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qa7c8KFcEeSK_vfd3NHBGg")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.")]
[DerivedFrom(typeof(DTCCPayoutTypeCode))]
public enum DTCCPayoutType4Code
{
    /// <summary>
    /// Payout consisting of securities.
    /// Encoded/decoded by serializers as "SECU".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_xKOmgaFcEeSK_vfd3NHBGg")]
    [Description(@"Payout consisting of securities.")]
    Securities = DTCCPayoutTypeCode.Securities, // same ordinal as derivation source for type conversions
    
}
