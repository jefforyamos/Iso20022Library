﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TMSContactLevel2Code.  ISO2002 ID# _cNM_kIqKEeSRT5rEzcAHEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Urgency of the command.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cNM_kIqKEeSRT5rEzcAHEw")]
[Description(@"Urgency of the command.")]
[DerivedFrom(typeof(TMSContactLevelCode))]
public enum TMSContactLevel2Code
{
    /// <summary>
    /// Terminal management system has to be contacted as soon as possible (for example after reconciliation).
    /// Encoded/decoded by serializers as "ASAP".
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_fZ92gYqKEeSRT5rEzcAHEw")]
    [Description(@"Terminal management system has to be contacted as soon as possible (for example after reconciliation).")]
    AsSoonAsPossible = TMSContactLevelCode.AsSoonAsPossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Terminal management system has to be contacted before the next transaction.
    /// Encoded/decoded by serializers as "CRIT".
    /// </summary>
    [EnumMember(Value = "CRIT")]
    [IsoId("_feJL4YqKEeSRT5rEzcAHEw")]
    [Description(@"Terminal management system has to be contacted before the next transaction.")]
    Critical = TMSContactLevelCode.Critical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Terminal management system has to be contacted at the date and time provided.
    /// Encoded/decoded by serializers as "DTIM".
    /// </summary>
    [EnumMember(Value = "DTIM")]
    [IsoId("_fidrMYqKEeSRT5rEzcAHEw")]
    [Description(@"Terminal management system has to be contacted at the date and time provided.")]
    DateTime = TMSContactLevelCode.DateTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// After the end of the customer session.
    /// Encoded/decoded by serializers as "ENCS".
    /// </summary>
    [EnumMember(Value = "ENCS")]
    [IsoId("_fn1TYYqKEeSRT5rEzcAHEw")]
    [Description(@"After the end of the customer session.")]
    EndCustomerSession = TMSContactLevelCode.EndCustomerSession, // same ordinal as derivation source for type conversions
    
}
