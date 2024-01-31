﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InternalPartyRole1Code.  ISO2002 ID# __q6voAkhEeWGouz230Xp5Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role as an internal party in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__q6voAkhEeWGouz230Xp5Q")]
[Description(@"Specifies the role as an internal party in the transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum InternalPartyRole1Code
{
    /// <summary>
    /// Party acting as an internal agent.
    /// Encoded/decoded by serializers as "INTC".
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_T0-jUR5ZEeWc9bJOIIhUUw")]
    [Description(@"Party acting as an internal agent.")]
    Internal = PartyRoleCode.Internal, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InternalPartyRole1CodeMetadataExtensions
{
    private static readonly InternalPartyRole1CodeDropdownSource _dropdownSource = new InternalPartyRole1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInternalPartyRole1CodeDropdownRow GetMetadata(this InternalPartyRole1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


