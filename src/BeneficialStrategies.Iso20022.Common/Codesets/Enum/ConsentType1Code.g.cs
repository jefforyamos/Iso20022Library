﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ConsentType1Code.  ISO2002 ID# _Ux3xACHnEeOQ7qT4JUI53A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of consent announced.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ux3xACHnEeOQ7qT4JUI53A")]
[Description(@"Specifies the type of consent announced.")]
[DerivedFrom(typeof(ConsentTypeCode))]
public enum ConsentType1Code
{
    /// <summary>
    /// Change in the terms and conditions of the bond.
    /// Encoded/decoded by serializers as "ChangeInTerms".
    /// </summary>
    [EnumMember(Value = "CTRM")]
    [IsoId("_Wr3YgSHnEeOQ7qT4JUI53A")]
    [Description(@"Change in the terms and conditions of the bond.")]
    ChangeInTerms,
    
    /// <summary>
    /// Change in the due and payable conditions.
    /// Encoded/decoded by serializers as "DueAndPayable".
    /// </summary>
    [EnumMember(Value = "DUPY")]
    [IsoId("_WzTdQSHnEeOQ7qT4JUI53A")]
    [Description(@"Change in the due and payable conditions.")]
    DueAndPayable,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ConsentType1CodeMetadataExtensions
{
    private static readonly ConsentType1CodeDropdownSource _dropdownSource = new ConsentType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IConsentType1CodeDropdownRow GetMetadata(this ConsentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


