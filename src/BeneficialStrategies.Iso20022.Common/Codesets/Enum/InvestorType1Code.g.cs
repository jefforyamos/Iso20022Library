﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestorType1Code.  ISO2002 ID# _haryuGliEeGaMcKyqKNRfQ_4555923.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_haryuGliEeGaMcKyqKNRfQ_4555923")]
[Description(@"Specifies the type of investor.")]
[DerivedFrom(typeof(InvestorTypeCode))]
public enum InvestorType1Code
{
    /// <summary>
    /// Investor is a retail investor.
    /// Encoded/decoded by serializers as "RETL".
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_haryuWliEeGaMcKyqKNRfQ_-1196008348")]
    [Description(@"Investor is a retail investor.")]
    Retail = InvestorTypeCode.Retail, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor is a professional or institutional investor.
    /// Encoded/decoded by serializers as "PROF".
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_haryumliEeGaMcKyqKNRfQ_271140415")]
    [Description(@"Investor is a professional or institutional investor.")]
    Professional = InvestorTypeCode.Professional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor is an employee.
    /// Encoded/decoded by serializers as "STAF".
    /// </summary>
    [EnumMember(Value = "STAF")]
    [IsoId("_haryu2liEeGaMcKyqKNRfQ_-1207107125")]
    [Description(@"Investor is an employee.")]
    Staff = InvestorTypeCode.Staff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor is a physical person.
    /// Encoded/decoded by serializers as "PPER".
    /// </summary>
    [EnumMember(Value = "PPER")]
    [IsoId("_haryvGliEeGaMcKyqKNRfQ_260041638")]
    [Description(@"Investor is a physical person.")]
    PhysicalPerson = InvestorTypeCode.PhysicalPerson, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InvestorType1CodeMetadataExtensions
{
    private static readonly InvestorType1CodeDropdownSource _dropdownSource = new InvestorType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInvestorType1CodeDropdownRow GetMetadata(this InvestorType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


