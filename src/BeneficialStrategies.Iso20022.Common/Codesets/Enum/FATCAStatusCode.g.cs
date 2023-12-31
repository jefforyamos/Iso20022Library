﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FATCAStatusCode.  ISO2002 ID# _D8aD4QjSEeS5F6qHcKOrew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the Foreign Account Tax Compliance Act (FATCA) status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_D8aD4QjSEeS5F6qHcKOrew")]
[Description(@"Specifies the Foreign Account Tax Compliance Act (FATCA) status.")]
[Derivations(typeof(FATCAStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum FATCAStatusCode
{
    /// <summary>
    /// Account holder type is an owner-documented financial institution with specified US owner(s).
    /// Encoded/decoded by serializers as "F101".
    /// </summary>
    [EnumMember(Value = "F101")]
    [IsoId("_HAp4AAjSEeS5F6qHcKOrew")]
    [Description(@"Account holder type is an owner-documented financial institution with specified US owner(s).")]
    FATCA101,
    
    /// <summary>
    /// Account holder type is a passive non-financial entity with substantial US owner(s).
    /// Encoded/decoded by serializers as "F102".
    /// </summary>
    [EnumMember(Value = "F102")]
    [IsoId("_3IzZEAjSEeS5F6qHcKOrew")]
    [Description(@"Account holder type is a passive non-financial entity with substantial US owner(s).")]
    FATCA102,
    
    /// <summary>
    /// Account holder type is a non-participating financial institution.
    /// Encoded/decoded by serializers as "F103".
    /// </summary>
    [EnumMember(Value = "F103")]
    [IsoId("_55_HQAjSEeS5F6qHcKOrew")]
    [Description(@"Account holder type is a non-participating financial institution.")]
    FATCA103,
    
    /// <summary>
    /// Account holder type is a specified US person.
    /// Encoded/decoded by serializers as "F104".
    /// </summary>
    [EnumMember(Value = "F104")]
    [IsoId("_9YB7cAjSEeS5F6qHcKOrew")]
    [Description(@"Account holder type is a specified US person.")]
    FATCA104,
    
    /// <summary>
    /// Account holder type is a direct reporting non-financial foreign entity (NFFE).
    /// Encoded/decoded by serializers as "F105".
    /// </summary>
    [EnumMember(Value = "F105")]
    [IsoId("_Wzlv0AjTEeS5F6qHcKOrew")]
    [Description(@"Account holder type is a direct reporting non-financial foreign entity (NFFE).")]
    FATCA105,
    
    /// <summary>
    /// Account pool reporting type is a recalcitrant account holder with US indicia.
    /// Encoded/decoded by serializers as "F201".
    /// </summary>
    [EnumMember(Value = "F201")]
    [IsoId("_ap1BkAjTEeS5F6qHcKOrew")]
    [Description(@"Account pool reporting type is a recalcitrant account holder with US indicia.")]
    FATCA201,
    
    /// <summary>
    /// Account pool reporting type is a recalcitrant account holder without US indicia.
    /// Encoded/decoded by serializers as "F202".
    /// </summary>
    [EnumMember(Value = "F202")]
    [IsoId("_82OZcAjTEeS5F6qHcKOrew")]
    [Description(@"Account pool reporting type is a recalcitrant account holder without US indicia.")]
    FATCA202,
    
    /// <summary>
    /// Account pool reporting type is a dormant account.
    /// Encoded/decoded by serializers as "F203".
    /// </summary>
    [EnumMember(Value = "F203")]
    [IsoId("__wfyMAjTEeS5F6qHcKOrew")]
    [Description(@"Account pool reporting type is a dormant account.")]
    FATCA203,
    
    /// <summary>
    /// Account pool reporting type is a non-participating foreign financial institution.
    /// Encoded/decoded by serializers as "F204".
    /// </summary>
    [EnumMember(Value = "F204")]
    [IsoId("_D9ySAAjUEeS5F6qHcKOrew")]
    [Description(@"Account pool reporting type is a non-participating foreign financial institution.")]
    FATCA204,
    
    /// <summary>
    /// Account pool reporting type is a recalcitrant account holder that is a US person.
    /// Encoded/decoded by serializers as "F205".
    /// </summary>
    [EnumMember(Value = "F205")]
    [IsoId("_HllfIAjUEeS5F6qHcKOrew")]
    [Description(@"Account pool reporting type is a recalcitrant account holder that is a US person.")]
    FATCA205,
    
    /// <summary>
    /// Account pool reporting type is recalcitrant account holder that is a passive non-financial foreign entity (NFFE).
    /// Encoded/decoded by serializers as "F206".
    /// </summary>
    [EnumMember(Value = "F206")]
    [IsoId("_LukGsAjUEeS5F6qHcKOrew")]
    [Description(@"Account pool reporting type is recalcitrant account holder that is a passive non-financial foreign entity (NFFE).")]
    FATCA206,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FATCAStatusCodeMetadataExtensions
{
    private static readonly FATCAStatusCodeDropdownSource _dropdownSource = new FATCAStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFATCAStatusCodeDropdownRow GetMetadata(this FATCAStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


