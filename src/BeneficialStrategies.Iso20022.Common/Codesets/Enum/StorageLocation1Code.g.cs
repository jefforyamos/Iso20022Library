﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StorageLocation1Code.  ISO2002 ID# _WmlrkJx_EeuwYeL1lHu9zw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code that specifies the storage location.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WmlrkJx_EeuwYeL1lHu9zw")]
[Description(@"Code that specifies the storage location.")]
[DerivedFrom(typeof(StorageLocationCode))]
public enum StorageLocation1Code
{
    /// <summary>
    /// Storage is in wallet managed by card acceptor.
    /// Encoded/decoded by serializers as "CardAcceptorWallet".
    /// </summary>
    [EnumMember(Value = "CAWL")]
    [IsoId("_d9jSEZx_EeuwYeL1lHu9zw")]
    [Description(@"Storage is in wallet managed by card acceptor.")]
    CardAcceptorWallet,
    
    /// <summary>
    /// Stored in device.
    /// Encoded/decoded by serializers as "Device".
    /// </summary>
    [EnumMember(Value = "DVCE")]
    [IsoId("_eGbhQZx_EeuwYeL1lHu9zw")]
    [Description(@"Stored in device.")]
    Device,
    
    /// <summary>
    /// Storage is in wallet managed by Issuer.
    /// Encoded/decoded by serializers as "IssuerWallet".
    /// </summary>
    [EnumMember(Value = "ISWL")]
    [IsoId("_euCT0Zx_EeuwYeL1lHu9zw")]
    [Description(@"Storage is in wallet managed by Issuer.")]
    IssuerWallet,
    
    /// <summary>
    /// Storage is on file.
    /// Encoded/decoded by serializers as "OnFile".
    /// </summary>
    [EnumMember(Value = "ONFL")]
    [IsoId("_eu5PcZx_EeuwYeL1lHu9zw")]
    [Description(@"Storage is on file.")]
    OnFile,
    
    /// <summary>
    /// Code defined by national standards organisation.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_e5A0wZx_EeuwYeL1lHu9zw")]
    [Description(@"Code defined by national standards organisation.")]
    OtherNational,
    
    /// <summary>
    /// Code defined by private agreement.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_fhei8Zx_EeuwYeL1lHu9zw")]
    [Description(@"Code defined by private agreement.")]
    OtherPrivate,
    
    /// <summary>
    /// Storage location is in wallet managed by a third party.
    /// Encoded/decoded by serializers as "ThirdPartyWallet".
    /// </summary>
    [EnumMember(Value = "TPWL")]
    [IsoId("_fiTpYZx_EeuwYeL1lHu9zw")]
    [Description(@"Storage location is in wallet managed by a third party.")]
    ThirdPartyWallet,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StorageLocation1CodeMetadataExtensions
{
    private static readonly StorageLocation1CodeDropdownSource _dropdownSource = new StorageLocation1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStorageLocation1CodeDropdownRow GetMetadata(this StorageLocation1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


