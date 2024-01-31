﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DebitType1Code.  ISO2002 ID# _Vbn78MmKEeWAGphE2LvqeA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of debit to be applied to the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vbn78MmKEeWAGphE2LvqeA")]
[Description(@"Specifies the type of debit to be applied to the payment.")]
[DerivedFrom(typeof(DebitTypeCode))]
public enum DebitType1Code
{
    /// <summary>
    /// Debit is performed as a global debit for all instructions in the file.
    /// Encoded/decoded by serializers as "GLBL".
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_WbBjccmKEeWAGphE2LvqeA")]
    [Description(@"Debit is performed as a global debit for all instructions in the file.")]
    Global = DebitTypeCode.Global, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debit is performed as an individual single debit for each instruction in the file.
    /// Encoded/decoded by serializers as "SNGL".
    /// </summary>
    [EnumMember(Value = "SNGL")]
    [IsoId("_WmWpssmKEeWAGphE2LvqeA")]
    [Description(@"Debit is performed as an individual single debit for each instruction in the file.")]
    Single = DebitTypeCode.Single, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DebitType1CodeMetadataExtensions
{
    private static readonly DebitType1CodeDropdownSource _dropdownSource = new DebitType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDebitType1CodeDropdownRow GetMetadata(this DebitType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


