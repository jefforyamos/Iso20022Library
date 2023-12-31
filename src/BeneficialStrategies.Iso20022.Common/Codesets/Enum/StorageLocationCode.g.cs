﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StorageLocationCode.  ISO2002 ID# _b6ylkJx-EeuwYeL1lHu9zw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code that specifies the storage location.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_b6ylkJx-EeuwYeL1lHu9zw")]
[Description(@"Code that specifies the storage location.")]
[Derivations(typeof(StorageLocation1Code))]
// External derivations that should be provided by the proper interface are: 
public enum StorageLocationCode
{
    /// <summary>
    /// Stored in device.
    /// Encoded/decoded by serializers as "DVCE".
    /// </summary>
    [EnumMember(Value = "DVCE")]
    [IsoId("_k3ZUMJx-EeuwYeL1lHu9zw")]
    [Description(@"Stored in device.")]
    Device,
    
    /// <summary>
    /// Storage is on file.
    /// Encoded/decoded by serializers as "ONFL".
    /// </summary>
    [EnumMember(Value = "ONFL")]
    [IsoId("_qxgiMJx-EeuwYeL1lHu9zw")]
    [Description(@"Storage is on file.")]
    OnFile,
    
    /// <summary>
    /// Storage is in wallet managed by card acceptor.
    /// Encoded/decoded by serializers as "CAWL".
    /// </summary>
    [EnumMember(Value = "CAWL")]
    [IsoId("_xy5hUJx-EeuwYeL1lHu9zw")]
    [Description(@"Storage is in wallet managed by card acceptor.")]
    CardAcceptorWallet,
    
    /// <summary>
    /// Storage is in wallet managed by Issuer.
    /// Encoded/decoded by serializers as "ISWL".
    /// </summary>
    [EnumMember(Value = "ISWL")]
    [IsoId("_4I2WwJx-EeuwYeL1lHu9zw")]
    [Description(@"Storage is in wallet managed by Issuer.")]
    IssuerWallet,
    
    /// <summary>
    /// Storage location is in wallet managed by a third party.
    /// Encoded/decoded by serializers as "TPWL".
    /// </summary>
    [EnumMember(Value = "TPWL")]
    [IsoId("_-YK_wJx-EeuwYeL1lHu9zw")]
    [Description(@"Storage location is in wallet managed by a third party.")]
    ThirdPartyWallet,
    
    /// <summary>
    /// Code defined by private agreement.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_D7VGUJx_EeuwYeL1lHu9zw")]
    [Description(@"Code defined by private agreement.")]
    OtherPrivate,
    
    /// <summary>
    /// Code defined by national standards organisation.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_H9R40Jx_EeuwYeL1lHu9zw")]
    [Description(@"Code defined by national standards organisation.")]
    OtherNational,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StorageLocationCodeMetadataExtensions
{
    private static readonly StorageLocationCodeDropdownSource _dropdownSource = new StorageLocationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStorageLocationCodeDropdownRow GetMetadata(this StorageLocationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


