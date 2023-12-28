﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyRole1Code.  ISO2002 ID# _xiDWkCDSEeWCLu74WLgP4w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of the party in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xiDWkCDSEeWCLu74WLgP4w")]
[Description(@"Specifies the role of the party in the transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum PartyRole1Code
{
    /// <summary>
    /// Party that safekeeps and administers assets on behalf of the owner.
    /// Encoded/decoded by serializers as "Custodian".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_zsaVUSDSEeWCLu74WLgP4w")]
    [Description(@"Party that safekeeps and administers assets on behalf of the owner.")]
    Custodian,
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as "Investor".
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_0PE9gSDSEeWCLu74WLgP4w")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyRole1CodeMetadataExtensions
{
    private static readonly PartyRole1CodeDropdownSource _dropdownSource = new PartyRole1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyRole1CodeDropdownRow GetMetadata(this PartyRole1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


