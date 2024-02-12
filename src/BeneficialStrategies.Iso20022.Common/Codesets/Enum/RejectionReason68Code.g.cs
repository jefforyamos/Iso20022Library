﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason68Code.  ISO2002 ID# _t3k4mStHEeySlt9bF77XfA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t3k4mStHEeySlt9bF77XfA")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason68Code
{
    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_K7ukQStIEeye9qONztM6oQ")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as "EVNM".
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_K7ukQytIEeye9qONztM6oQ")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV3Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument's symbol has not been recognized.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_K7ukRStIEeye9qONztM6oQ")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol = RejectionReasonV3Code.UnknownSymbol, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient collateral proposed.
    /// Encoded/decoded by serializers as "ICOL".
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_K7ukRytIEeye9qONztM6oQ")]
    [Description(@"Insufficient collateral proposed.")]
    InsufficientCollateral = RejectionReasonV3Code.InsufficientCollateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Concentration limit was exceeded.
    /// Encoded/decoded by serializers as "CONL".
    /// </summary>
    [EnumMember(Value = "CONL")]
    [IsoId("_K7ukSStIEeye9qONztM6oQ")]
    [Description(@"Concentration limit was exceeded.")]
    ConcentrationLimitExceeded = RejectionReasonV3Code.ConcentrationLimitExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security is not eligible.
    /// Encoded/decoded by serializers as "ELIG".
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_K7ukSytIEeye9qONztM6oQ")]
    [Description(@"Security is not eligible.")]
    NonEligibleSecurity = RejectionReasonV3Code.NonEligibleSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as "INID".
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_K7ukTStIEeye9qONztM6oQ")]
    [Description(@"Instruction contains an invalid message identification, identification is unknown.")]
    InvalidIdentification = RejectionReasonV3Code.InvalidIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_K7ukTytIEeye9qONztM6oQ")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
}
