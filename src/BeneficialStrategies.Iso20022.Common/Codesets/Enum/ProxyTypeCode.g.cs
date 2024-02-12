﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProxyTypeCode.  ISO2002 ID# _ZWnIEtp-Ed-ak6NoX_4Aeg_-395428002.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of proxy person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZWnIEtp-Ed-ak6NoX_4Aeg_-395428002")]
[Description(@"Specifies the type of proxy person.")]
[Derivations(typeof(ProxyType2Code),typeof(ProxyType3Code))]
public enum ProxyTypeCode
{
    /// <summary>
    /// Chairman of the meeting is the proxy.
    /// Encoded/decoded by serializers as "CHRM".
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_ZWnIE9p-Ed-ak6NoX_4Aeg_-149773313")]
    [Description(@"Chairman of the meeting is the proxy.")]
    Chairman,
    
    /// <summary>
    /// Any type of proxy is allowed.
    /// Encoded/decoded by serializers as "DISC".
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_ZWnIFNp-Ed-ak6NoX_4Aeg_-62960027")]
    [Description(@"Any type of proxy is allowed.")]
    Discretionary,
    
    /// <summary>
    /// Proxy can only be a security holder.
    /// Encoded/decoded by serializers as "HLDR".
    /// </summary>
    [EnumMember(Value = "HLDR")]
    [IsoId("_ZWnIFdp-Ed-ak6NoX_4Aeg_-1999739739")]
    [Description(@"Proxy can only be a security holder.")]
    SecurityHolder,
    
    /// <summary>
    /// Neutral proxy nominated by the issuer to execute votes on behalf of investors at the meeting.
    /// Encoded/decoded by serializers as "NEPR".
    /// </summary>
    [EnumMember(Value = "NEPR")]
    [IsoId("_NsuHIBrfEeyhRdHRjakS2w")]
    [Description(@"Neutral proxy nominated by the issuer to execute votes on behalf of investors at the meeting.")]
    NeutralProxy,
    
}
