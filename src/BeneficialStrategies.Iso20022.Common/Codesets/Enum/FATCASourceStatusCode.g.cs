﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FATCASourceStatusCode.  ISO2002 ID# _yHODoQjUEeS5F6qHcKOrew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the source of Foreign Account Tax Compliance Act (FATCA) status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yHODoQjUEeS5F6qHcKOrew")]
[Description(@"Specifies the source of Foreign Account Tax Compliance Act (FATCA) status.")]
[Derivations(typeof(FATCASourceStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum FATCASourceStatusCode
{
    /// <summary>
    /// Source of the Foreign Account Tax Compliance Act (FATCA) status is as declared by the investor.
    /// Encoded/decoded by serializers as "DECL".
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_2BUhsAjUEeS5F6qHcKOrew")]
    [Description(@"Source of the Foreign Account Tax Compliance Act (FATCA) status is as declared by the investor.")]
    Declared,
    
    /// <summary>
    /// Source of the Foreign Account Tax Compliance Act (FATCA) status calculated.
    /// Encoded/decoded by serializers as "CALC".
    /// </summary>
    [EnumMember(Value = "CALC")]
    [IsoId("_2FoZ8AjUEeS5F6qHcKOrew")]
    [Description(@"Source of the Foreign Account Tax Compliance Act (FATCA) status calculated.")]
    Calculated,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FATCASourceStatusCodeMetadataExtensions
{
    private static readonly FATCASourceStatusCodeDropdownSource _dropdownSource = new FATCASourceStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFATCASourceStatusCodeDropdownRow GetMetadata(this FATCASourceStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


