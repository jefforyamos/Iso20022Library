﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TMSContactLevelCode.  ISO2002 ID# _TVWQAgEcEeCQm6a_G2yO_w_1626572766.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Level of urgency in contacting the terminal management system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVWQAgEcEeCQm6a_G2yO_w_1626572766")]
[Description(@"Level of urgency in contacting the terminal management system.")]
public enum TMSContactLevelCode
{
    /// <summary>
    /// Terminal management system has to be contacted before the next transaction.
    /// Encoded/decoded by serializers as "CRIT".
    /// </summary>
    [EnumMember(Value = "CRIT")]
    [IsoId("_TVWQAwEcEeCQm6a_G2yO_w_59106587")]
    [Description(@"Terminal management system has to be contacted before the next transaction.")]
    Critical,
    
    /// <summary>
    /// Terminal management system has to be contacted as soon as possible (for example after reconciliation).
    /// Encoded/decoded by serializers as "ASAP".
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_TVWQBAEcEeCQm6a_G2yO_w_-695643287")]
    [Description(@"Terminal management system has to be contacted as soon as possible (for example after reconciliation).")]
    AsSoonAsPossible,
    
    /// <summary>
    /// Terminal management system has to be contacted at the date and time provided.
    /// Encoded/decoded by serializers as "DTIM".
    /// </summary>
    [EnumMember(Value = "DTIM")]
    [IsoId("_TVWQBQEcEeCQm6a_G2yO_w_-639992749")]
    [Description(@"Terminal management system has to be contacted at the date and time provided.")]
    DateTime,
    
    /// <summary>
    /// After the end of the customer session.
    /// Encoded/decoded by serializers as "ENCS".
    /// </summary>
    [EnumMember(Value = "ENCS")]
    [IsoId("_YrKcMIqKEeSRT5rEzcAHEw")]
    [Description(@"After the end of the customer session.")]
    EndCustomerSession,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TMSContactLevelCodeMetadataExtensions
{
    private static readonly TMSContactLevelCodeDropdownSource _dropdownSource = new TMSContactLevelCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITMSContactLevelCodeDropdownRow GetMetadata(this TMSContactLevelCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


