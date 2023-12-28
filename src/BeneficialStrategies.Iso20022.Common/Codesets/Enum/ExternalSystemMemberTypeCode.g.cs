﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalSystemMemberTypeCode.  ISO2002 ID# _7geSbHhfEeidzqjNEfehPg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the membership of a party in a system, as published in an external system member type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7geSbHhfEeidzqjNEfehPg")]
[Description(@"Specifies the nature of the membership of a party in a system, as published in an external system member type code set. External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalSystemMemberType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExternalSystemMemberTypeCode
{
    /// <summary>
    /// Member has full rights in the system. In principle, this membership status entails financial responsibility for its own operations and sponsored members' operations submitted to the system.
    /// Encoded/decoded by serializers as "DRCT".
    /// </summary>
    [EnumMember(Value = "DRCT")]
    [IsoId("_uiDnM_RYEeuLhpyIdtJzwg")]
    [Description(@"Member has full rights in the system. In principle, this membership status entails financial responsibility for its own operations and sponsored members' operations submitted to the system.")]
    Direct,
    
    /// <summary>
    /// Member has limited rights in the system specifications. In principle, this membership status entails no financial responsibility for its operations submitted to the system.
    /// Encoded/decoded by serializers as "IDRT".
    /// </summary>
    [EnumMember(Value = "IDRT")]
    [IsoId("_uiDnNvRYEeuLhpyIdtJzwg")]
    [Description(@"Member has limited rights in the system specifications. In principle, this membership status entails no financial responsibility for its operations submitted to the system.")]
    Indirect,
    
    /// <summary>
    /// Member has access to the system from a remote location or through remote technical means.
    /// Encoded/decoded by serializers as "RMTE".
    /// </summary>
    [EnumMember(Value = "RMTE")]
    [IsoId("_uiDnOfRYEeuLhpyIdtJzwg")]
    [Description(@"Member has access to the system from a remote location or through remote technical means.")]
    Remote,
    
    /// <summary>
    /// Member is entitled to access the Euro1 system of the Euro Banking Association (EBA).
    /// Encoded/decoded by serializers as "EURO".
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_uiNYMPRYEeuLhpyIdtJzwg")]
    [Description(@"Member is entitled to access the Euro1 system of the Euro Banking Association (EBA).")]
    EURO1,
    
    /// <summary>
    /// Member is entitled to access the Step1 system of the Euro Banking Association (EBA).
    /// Encoded/decoded by serializers as "STEP".
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("_uiNYM_RYEeuLhpyIdtJzwg")]
    [Description(@"Member is entitled to access the Step1 system of the Euro Banking Association (EBA).")]
    STEP1,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalSystemMemberTypeCodeMetadataExtensions
{
    private static readonly ExternalSystemMemberTypeCodeDropdownSource _dropdownSource = new ExternalSystemMemberTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalSystemMemberTypeCodeDropdownRow GetMetadata(this ExternalSystemMemberTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


