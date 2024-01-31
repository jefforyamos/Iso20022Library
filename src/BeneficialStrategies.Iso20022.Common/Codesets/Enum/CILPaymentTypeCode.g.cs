﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CILPaymentTypeCode.  ISO2002 ID# _1n7u0jL3EeKU9IrkkToqcw_2037230597.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies cash in lieu payment type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1n7u0jL3EeKU9IrkkToqcw_2037230597")]
[Description(@"Specifies cash in lieu payment type.")]
[Derivations(typeof(CILPaymentType1Code))]
public enum CILPaymentTypeCode
{
    /// <summary>
    /// Event pays daily at fixed rate.
    /// Encoded/decoded by serializers as "FIXD".
    /// </summary>
    [EnumMember(Value = "FIXD")]
    [IsoId("_1n7u0zL3EeKU9IrkkToqcw_-110040090")]
    [Description(@"Event pays daily at fixed rate.")]
    Fixed,
    
    /// <summary>
    /// Price can fluctuate. Payment is held until released.
    /// Encoded/decoded by serializers as "HOLD".
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_1n7u1DL3EeKU9IrkkToqcw_-307768782")]
    [Description(@"Price can fluctuate. Payment is held until released.")]
    Hold,
    
    /// <summary>
    /// Pays on same day as convert/exercise instructions.
    /// Encoded/decoded by serializers as "PCIL".
    /// </summary>
    [EnumMember(Value = "PCIL")]
    [IsoId("_1n7u1TL3EeKU9IrkkToqcw_-1762418008")]
    [Description(@"Pays on same day as convert/exercise instructions.")]
    PayCIL,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CILPaymentTypeCodeMetadataExtensions
{
    private static readonly CILPaymentTypeCodeDropdownSource _dropdownSource = new CILPaymentTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICILPaymentTypeCodeDropdownRow GetMetadata(this CILPaymentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


