﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MailTypeCode.  ISO2002 ID# _OrfCICCXEeWJd9HF2tO7BA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of mail service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OrfCICCXEeWJd9HF2tO7BA")]
[Description(@"Specifies the type of mail service.")]
[Derivations(typeof(MailType1Code))]
public enum MailTypeCode
{
    /// <summary>
    /// Air mail.
    /// Encoded/decoded by serializers as &quot;AIRM&quot;.
    /// </summary>
    [EnumMember(Value = "AIRM")]
    [IsoId("_TWh08CCXEeWJd9HF2tO7BA")]
    [Description(@"Air mail.")]
    AirMail,
    
    /// <summary>
    /// Ordinary mail.
    /// Encoded/decoded by serializers as &quot;ORDM&quot;.
    /// </summary>
    [EnumMember(Value = "ORDM")]
    [IsoId("_WlBxQCCXEeWJd9HF2tO7BA")]
    [Description(@"Ordinary mail.")]
    OrdinaryMail,
    
    /// <summary>
    /// Registered Mail.
    /// Encoded/decoded by serializers as &quot;REGM&quot;.
    /// </summary>
    [EnumMember(Value = "REGM")]
    [IsoId("_ZmldwCCXEeWJd9HF2tO7BA")]
    [Description(@"Registered Mail.")]
    RegisteredMail,
    
}
