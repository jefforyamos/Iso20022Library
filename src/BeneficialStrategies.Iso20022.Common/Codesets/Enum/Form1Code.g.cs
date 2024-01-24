﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Form1Code.  ISO2002 ID# _Vr6_Btp-Ed-ak6NoX_4Aeg_1756006615.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a physical form is required.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vr6_Btp-Ed-ak6NoX_4Aeg_1756006615")]
[Description(@"Specifies whether a physical form is required.")]
[DerivedFrom(typeof(FormCode))]
public enum Form1Code
{
    /// <summary>
    /// A phsyical form is required through the main fund order desk.
    /// Encoded/decoded by serializers as "REQU".
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_Vr6_B9p-Ed-ak6NoX_4Aeg_1756006617")]
    [Description(@"A phsyical form is required through the main fund order desk.")]
    Required = FormCode.Required, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A phsyical form is not required through the main fund order desk.
    /// Encoded/decoded by serializers as "NREQ".
    /// </summary>
    [EnumMember(Value = "NREQ")]
    [IsoId("_Vr6_CNp-Ed-ak6NoX_4Aeg_1756006646")]
    [Description(@"A phsyical form is not required through the main fund order desk.")]
    NotRequired = FormCode.NotRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A phsyical form with the investor's written signature is required through the main fund order desk.
    /// Encoded/decoded by serializers as "SREQ".
    /// </summary>
    [EnumMember(Value = "SREQ")]
    [IsoId("_VsEwANp-Ed-ak6NoX_4Aeg_1756006647")]
    [Description(@"A phsyical form with the investor's written signature is required through the main fund order desk.")]
    SignatureRequired = FormCode.SignatureRequired, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Form1CodeMetadataExtensions
{
    private static readonly Form1CodeDropdownSource _dropdownSource = new Form1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IForm1CodeDropdownRow GetMetadata(this Form1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


