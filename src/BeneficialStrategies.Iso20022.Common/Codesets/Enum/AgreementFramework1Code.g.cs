﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AgreementFramework1Code.  ISO2002 ID# _YbT9d9p-Ed-ak6NoX_4Aeg_643669747.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the agreement type details for the margin call.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbT9d9p-Ed-ak6NoX_4Aeg_643669747")]
[Description(@"Specifies the agreement type details for the margin call.")]
[DerivedFrom(typeof(AgreementFrameworkCode))]
public enum AgreementFramework1Code
{
    /// <summary>
    /// French Banker's Association Agreement.
    /// Encoded/decoded by serializers as "FBAAgreement".
    /// </summary>
    [EnumMember(Value = "FBAA")]
    [IsoId("_YbdHYNp-Ed-ak6NoX_4Aeg_2036640841")]
    [Description(@"French Banker's Association Agreement.")]
    FBAAgreement,
    
    /// <summary>
    /// British Banker's Association Agreement.
    /// Encoded/decoded by serializers as "BBAAgreement".
    /// </summary>
    [EnumMember(Value = "BBAA")]
    [IsoId("_YbdHYdp-Ed-ak6NoX_4Aeg_-1672379429")]
    [Description(@"British Banker's Association Agreement.")]
    BBAAgreement,
    
    /// <summary>
    /// German Rahmenvertrag Agreement.
    /// Encoded/decoded by serializers as "GermanRahmenvertragAgreement".
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_YbdHYtp-Ed-ak6NoX_4Aeg_1243904924")]
    [Description(@"German Rahmenvertrag Agreement.")]
    GermanRahmenvertragAgreement,
    
    /// <summary>
    /// International Swaps and Derivatives Association Agreement.
    /// Encoded/decoded by serializers as "ISDAAgreement".
    /// </summary>
    [EnumMember(Value = "ISDA")]
    [IsoId("_YbdHY9p-Ed-ak6NoX_4Aeg_1130065858")]
    [Description(@"International Swaps and Derivatives Association Agreement.")]
    ISDAAgreement,
    
    /// <summary>
    /// No information about the master agreement is available.
    /// Encoded/decoded by serializers as "NoReference".
    /// </summary>
    [EnumMember(Value = "NONR")]
    [IsoId("_YbdHZNp-Ed-ak6NoX_4Aeg_1232806147")]
    [Description(@"No information about the master agreement is available.")]
    NoReference,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AgreementFramework1CodeMetadataExtensions
{
    private static readonly AgreementFramework1CodeDropdownSource _dropdownSource = new AgreementFramework1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAgreementFramework1CodeDropdownRow GetMetadata(this AgreementFramework1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


