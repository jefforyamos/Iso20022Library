﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FailureReason5Code.  ISO2002 ID# _zsPEIIr-EeSvuOJS0mmL0g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Incident occurring on a device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zsPEIIr-EeSvuOJS0mmL0g")]
[Description(@"Incident occurring on a device.")]
[DerivedFrom(typeof(FailureReasonCode))]
public enum FailureReason5Code
{
    /// <summary>
    /// General security error.
    /// Encoded/decoded by serializers as &quot;SECR&quot;.
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_4Y2kQYr-EeSvuOJS0mmL0g")]
    [Description(@"General security error.")]
    Security = FailureReasonCode.Security, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Hardware error on the device.
    /// Encoded/decoded by serializers as &quot;HRDW&quot;.
    /// </summary>
    [EnumMember(Value = "HRDW")]
    [IsoId("_-lfssYr-EeSvuOJS0mmL0g")]
    [Description(@"Hardware error on the device.")]
    Hardware = FailureReasonCode.Hardware, // same ordinal as derivation source for type conversions
    
}
