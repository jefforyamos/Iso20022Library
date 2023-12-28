﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BillingSubServiceQualifierCode.  ISO2002 ID# _6WqIoZqlEeGSON8vddiWzQ_-379883890.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Qualifies the content of the subservice code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WqIoZqlEeGSON8vddiWzQ_-379883890")]
[Description(@"Qualifies the content of the subservice code.")]
[Derivations(typeof(BillingSubServiceQualifier1Code))]
// External derivations that should be provided by the proper interface are: 
public enum BillingSubServiceQualifierCode
{
    /// <summary>
    /// Subservice code contains a lockbox number which identifies the lockbox using the service.
    /// Encoded/decoded by serializers as "LBOX".
    /// </summary>
    [EnumMember(Value = "LBOX")]
    [IsoId("_6WqIopqlEeGSON8vddiWzQ_1477365777")]
    [Description(@"Subservice code contains a lockbox number which identifies the lockbox using the service.")]
    Lockbox,
    
    /// <summary>
    /// Subservice code contains a store number which identifies the store using the service.
    /// Encoded/decoded by serializers as "STOR".
    /// </summary>
    [EnumMember(Value = "STOR")]
    [IsoId("_6WqIo5qlEeGSON8vddiWzQ_999391067")]
    [Description(@"Subservice code contains a store number which identifies the store using the service.")]
    Store,
    
    /// <summary>
    /// Meaning of the subservice code is established by the trading partners.
    /// Encoded/decoded by serializers as "BILA".
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_6WqIpJqlEeGSON8vddiWzQ_-769215275")]
    [Description(@"Meaning of the subservice code is established by the trading partners.")]
    BilaterallyAgreed,
    
    /// <summary>
    /// Subservice code is an arbitrary sequence number used to uniquely identify this Service and prevent duplicate services within this statement.
    /// Encoded/decoded by serializers as "SEQN".
    /// </summary>
    [EnumMember(Value = "SEQN")]
    [IsoId("_6WqIpZqlEeGSON8vddiWzQ_-436014445")]
    [Description(@"Subservice code is an arbitrary sequence number used to uniquely identify this Service and prevent duplicate services within this statement.")]
    SequenceNumber,
    
    /// <summary>
    /// Subservice code is the account number of a member of a relationship structure. This allows a parent statement to include the same service as rolled up from its member accounts and still avoid duplicate service identification within the statement.
    /// Encoded/decoded by serializers as "MACT".
    /// </summary>
    [EnumMember(Value = "MACT")]
    [IsoId("_6WqIppqlEeGSON8vddiWzQ_1142554083")]
    [Description(@"Subservice code is the account number of a member of a relationship structure. This allows a parent statement to include the same service as rolled up from its member accounts and still avoid duplicate service identification within the statement.")]
    MemberAccount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BillingSubServiceQualifierCodeMetadataExtensions
{
    private static readonly BillingSubServiceQualifierCodeDropdownSource _dropdownSource = new BillingSubServiceQualifierCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBillingSubServiceQualifierCodeDropdownRow GetMetadata(this BillingSubServiceQualifierCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


