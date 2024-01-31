﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PhysicalTransferTypeCode.  ISO2002 ID# _XGHPAPrqEeCJc7cZxzE2fg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the financial instrument is to be physically delivered or is a dematerialised transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XGHPAPrqEeCJc7cZxzE2fg")]
[Description(@"Specifies whether the financial instrument is to be physically delivered or is a dematerialised transfer.")]
[Derivations(typeof(PhysicalTransferType1Code))]
public enum PhysicalTransferTypeCode
{
    /// <summary>
    /// Physical transfer.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_Xi4DgfrqEeCJc7cZxzE2fg")]
    [Description(@"Physical transfer.")]
    Physical,
    
    /// <summary>
    /// Dematerialised transfer.
    /// Encoded/decoded by serializers as "DEMT".
    /// </summary>
    [EnumMember(Value = "DEMT")]
    [IsoId("_mSc2V_rqEeCJc7cZxzE2fg")]
    [Description(@"Dematerialised transfer.")]
    Dematerialised,
    
    /// <summary>
    /// Cash transfer.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_L5wXwM5NEeSc85GUbgBycw")]
    [Description(@"Cash transfer.")]
    Cash,
    
    /// <summary>
    /// Determined by a third party or optional for counterparty.
    /// Encoded/decoded by serializers as "OPTN".
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_OPQ2kM5NEeSc85GUbgBycw")]
    [Description(@"Determined by a third party or optional for counterparty.")]
    Optional,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PhysicalTransferTypeCodeMetadataExtensions
{
    private static readonly PhysicalTransferTypeCodeDropdownSource _dropdownSource = new PhysicalTransferTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPhysicalTransferTypeCodeDropdownRow GetMetadata(this PhysicalTransferTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


